FROM nginx:1.25.5-alpine

COPY /docker/nginx/template-variables /etc/nginx/templates/10-variables.conf.template
COPY /client/public /app/client/public
COPY /docker/nginx/non-prod-default.conf /etc/nginx/conf.d/default.conf