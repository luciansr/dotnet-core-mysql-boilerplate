# MariaDB Container - How to setup [(ref.)](https://linoxide.com/containers/setup-use-mariadb-docker-container/)

1. Run ```docker build -t lucian/mariadb .```  
2. Run ```docker run --name mariadb1 -d -p 3306:3306 --restart unless-stopped lucian/mariadb```
(we'll be using ```-p 3306:3306``` now because we will access it from outside a container)

# How to run MariaDB from inside the container:
1. Run ```docker exec -it mariadb1 bash```
2. Run ```mysql --user=root --password=root```
3. Run `exit`
4. Run `exit`
5. Run ```docker inspect mariadb1 | grep IPAddress``` to see your docker container IP

# How to remove the container

1. Run ```docker stop mariadb1```
2. Run ```docker rm mariadb1```

# How to remove the image (remove all containers derived from it first)

1. Run ```docker rmi image lucian/mariadb```