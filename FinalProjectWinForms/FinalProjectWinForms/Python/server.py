import socket
import sys
from threading import Thread


class Server(object):
    def __init__(self):
        self.__sockets = []  # type: list[socket]
        self.__port = int(sys.argv[1])
        self.__messages_to_deliver = {}  # type: dict[str: socket]
        self.__last_message = ""
        self.__host = None
        self.__my_socket = socket.socket()  # type: socket
        self.__my_socket.bind(("", self.__port))
        # print str.format("bind to port, {0}, {1}", self.__port, sys.argv[1])
        self.__my_socket.listen(5)

    def __wait_for_new_users(self):
        while True:
            new_socket, address = self.__my_socket.accept()
            print "new one!"
            if len(self.__sockets) == 0 and self.__host is None:
                self.__host = new_socket
            else:
                new_socket.send(self.__last_message)
                print "send last message"
            self.__sockets.append(new_socket)
            thread = Thread(target=self.__listen_to_client, args=(new_socket,))
            thread.start()

    def __listen_to_client(self, client):
        while True:
            try:
                length = self.__receive_length(client)
                message = client.recv(length)
                if (client == self.__host and message == "bye"):
                    self.__messages_to_deliver = {"3,bye": client}
                print "len: ", len(message)
                message_with_length = str.format("{0},{1}", length, message)
                if (self.__is_edit_message(message)):
                    self.__last_message = message_with_length
                print "received " + message_with_length
                self.__messages_to_deliver[message_with_length] = client
            except:
                self.__sockets.remove(client)
                break

    def __receive_length(self, client):
        length = ''
        chunk = ''
        while chunk != ',':
            chunk = client.recv(1)
            if (chunk != ','):
                length += chunk
        return int(length)

    def __send_messages(self):
        while True:
            # for message in self.__messages_to_deliver:
            if len(self.__messages_to_deliver) != 0:
                message, sender = self.__messages_to_deliver.popitem()
                # sender = self.__messages_to_deliver[message]
                sockets_to_remove = []
                for sock in self.__sockets:
                    if sender != sock:
                        try:
                            sock.send(message)
                            print "send " + message
                        except socket.error:  # Can't send the message
                            sockets_to_remove.append(sock)
                for socket_to_remove in sockets_to_remove:
                    self.__sockets.remove(socket_to_remove)
            # print self.__messages_to_deliver
            # self.__messages_to_deliver = {}  # Delete all messages after sending them

    def __is_edit_message(self, message):
        if (message.count(',') < 2):
            return False
        first_comma = message.index(',')
        second_comma = message.index(',', first_comma + 1)
        message_type = message[first_comma + 1:second_comma]
        return message_type == "edit"

    def start(self):
        thread = Thread(target=self.__wait_for_new_users)
        thread.start()
        self.__send_messages()


if __name__ == '__main__':

    server = Server()
    server.start()
