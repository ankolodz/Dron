#include <thread>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <netinet/in.h>
#include <arpa/inet.h>

#define FRAME_SIZE 6
#define SERWER_PORT 11000
#define SERWER_IP "127.0.0.1"
#define MAX_CONNECTION 10
class Proxy{
    public:
        
    private:
        TCP_Socked socked;
        UART uart;
}

class TCP_Socked{
    public:
        TCP_Socked(Proxy* proxy){
            this->proxy = proxy; 
        }
        bool init()
        {
            if( inet_pton( AF_INET, SERWER_IP, & serwer.sin_addr ) <= 0 )
            {
                perror( "inet_pton() ERROR" );
                exit( 1 );
            }
        
            socket = socket( AF_INET, SOCK_STREAM, 0 );
            if( socket < 0 )
            {
                perror( "socket() ERROR" );
                exit( 2 );
            }
        
            len = sizeof( serwer );
            if( bind( socket,( struct sockaddr * ) & serwer, len ) < 0 )
            {
                perror( "bind() ERROR" );
                exit( 3 );
            }
        
            if( listen( socket, MAX_CONNECTION ) < 0 )
            {
                perror( "listen() ERROR" );
                exit( 4 );
            }
        }
        void lisiner(){
                printf( "Waiting for connection...\n" );
            
                struct sockaddr_in client = { };
            
                const int clientSocket = accept( socket,( struct sockaddr * ) & client, & len );
                if( clientSocket < 0 )
                {
                    perror( "accept() ERROR" );
                    continue;
                }
            
                unsigned char buffer[ FRAME_SIZE ] = { };
            
                while  (true)
                    if( recv( clientSocket, buffer, sizeof( buffer ), 0 ) <= 0 )
                    {
                        perror( "recv() ERROR" );
                        exit( 5 );
                    }
                    printf( "|Message from client|: %s \n", buffer );
                    // proxy.getUART         
                 }      
            
        }
        void connectController(){
            
        }shutdown( clientSocket, SHUT_RDWR );
        

    private:
        struct sockaddr_in serwer =
        {
            .sin_family = AF_INET,
            .sin_port = htons( SERWER_PORT )
        };
        int socket;
        bool 
        socklen_t len;
        Proxy* proxy;
};



int main()
{


   
   
    while( 1 )
    {
        printf( "Waiting for connection...\n" );
       
        struct sockaddr_in client = { };
       
        const int clientSocket = accept( socket_,( struct sockaddr * ) & client, & len );
        if( clientSocket < 0 )
        {
            perror( "accept() ERROR" );
            continue;
        }
       
        unsigned char buffer[ FRAME_SIZE ] = { };
       
        if( recv( clientSocket, buffer, sizeof( buffer ), 0 ) <= 0 )
        {
            perror( "recv() ERROR" );
            exit( 5 );
        }
        printf( "|Message from client|: %s \n", buffer );
       
        strcpy( buffer, "Message from server" );
        if( send( clientSocket, buffer, strlen( buffer ), 0 ) <= 0 )
        {
            perror( "send() ERROR" );
            exit( 6 );
        }
       
        shutdown( clientSocket, SHUT_RDWR );
    }
   
    shutdown( socket_, SHUT_RDWR );
}
//   gcc server.c -g -Wall -o server && ./server
