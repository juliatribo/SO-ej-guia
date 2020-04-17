#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>

int contador;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente (void *socket)
{
	int sock_conn;
	int *s;
	s=(int*) socket;
	sock_conn = *s;
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	
	int terminar =0;
	while (terminar==0)
	{
		
		
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		// Ya tenemos el c?digo de petici?n
		char nombre[20];
		
		if ((codigo !=0)&& (codigo!=6))
		{
			p = strtok( NULL, "/");
			strcpy (nombre, p);
			//Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		
		if (codigo ==0)
			terminar=1;
		else if (codigo==6)
			sprintf (respuesta,"%d",contador);
		else if (codigo ==1) //piden la longitd del nombre
			sprintf (respuesta,"%d",strlen (nombre));
		else if (codigo ==2)
		{
			// quieren saber si el nombre es bonito
			if((nombre[0]=='M') || (nombre[0]=='S'))
				strcpy (respuesta,"SI");
			else
				strcpy (respuesta,"NO");
		}
		else if (codigo == 3) //quiere saber si es alto
		{
			p = strtok( NULL, "/");
			float altura =  atof (p);
			if (altura > 1.70)
				sprintf (respuesta, "%s: eres alto",nombre);
			else
				sprintf (respuesta, "%s: eres bajo",nombre);
		}
		
		else if (codigo == 4)
		{
			
			int c=0;
			while (c<strlen(nombre))
			{
				nombre[c]=toupper(nombre[c]);
				c=c+1;
			}
			
			int i=0;
			char eman[strlen(nombre)];
			while (i<strlen(nombre))
			{
				eman[i] = nombre[strlen(nombre)-i-1];
				i=i+1;
			}
			if (strcmp(eman,nombre)==0)
				sprintf (respuesta, "YES");
			else
				sprintf (respuesta, "NO");
		}
		
		if (codigo == 5)
		{
			int i=0;
			while (i<strlen(nombre))
			{
				nombre[i]=toupper(nombre[i]);
				i=i+1;
			}
			sprintf (respuesta, nombre);
		}
		
		
		if (codigo !=0)
		{
			printf ("Respuesta: %s\n", respuesta);
			// Enviamos la respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		
		if (codigo ==1 || codigo ==2 || codigo ==3|| codigo ==4|| codigo ==5 )
		{
			pthread_mutex_lock(&mutex);
			contador = contador+1; 
			pthread_mutex_unlock(&mutex);
		}
		

		
		
	}
	close(sock_conn);
}


int main(int argc, char *argv[])
{
	
		
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9070);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	
	contador=0;
	int i;
	int sockets[100];
	pthread_t thread[100];
	i=0;
	// bucle infinito
	for (i=0;i<5;i++){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		// Se acabo el servicio para este cliente
		sockets[i] = sock_conn;
		pthread_create(&thread[i],NULL, AtenderCliente, &sockets[i]);
		 
	}
}

