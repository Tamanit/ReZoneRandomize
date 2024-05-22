FROM node:18.12.1-alpine AS builder
ENV NODE_ENV production

WORKDIR app/client

COPY /client .
COPY /.env ./client/src

RUN npm install
RUN npm run build

FROM nginx:1.25.5-alpine AS production
ENV NODE_ENV production

COPY --from=builder /app/client/build /usr/share/nginx/html

COPY /docker/nginx/template-variables /etc/nginx/templates/10-variables.conf.template
COPY /client/public /app/client/public
COPY /docker/nginx/default.conf /etc/nginx/conf.d/default.conf

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]