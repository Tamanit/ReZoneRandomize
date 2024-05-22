FROM node:18.12.1

WORKDIR app/client

COPY /client .
COPY /.env ./client/src

CMD npm install -y && npm start