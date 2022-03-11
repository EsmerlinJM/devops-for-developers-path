docker build -t learnbook/aspnetcore-server .
docker push learnbook/aspnetcore-server
docker run --rm -it -p 8088:80 learnbook/aspnetcore-server