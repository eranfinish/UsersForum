FROM node:18 AS build
WORKDIR /app
COPY users-forum-app/package*.json ./
RUN npm install --legacy-peer-deps
COPY users-forum-app/ .
RUN npm run build

FROM nginx:alpine
COPY --from=build /app/dist/users-forum-app /usr/share/nginx/html
EXPOSE 80
