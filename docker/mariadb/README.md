# MariaDB Container - How to setup [(ref.)](https://linoxide.com/containers/setup-use-mariadb-docker-container/)

1. Run 
```sh
docker build -t lucian/mariadb .
docker run --name mariadb1 -d -p 3306:3306 --restart unless-stopped lucian/mariadb
```
(we'll be using ```-p 3306:3306``` now because we will access it from outside a container)

# How to run MariaDB from inside the container:
1. Run 
```sh
docker exec -it mariadb1 bash
mysql --user=root --password=root
```


# How to remove the container

1. Run 
```sh
docker stop mariadb1
docker rm mariadb1
```

# How to remove the image (remove all containers derived from it first)

1. Run 
```sh
docker rmi image lucian/mariadb
```