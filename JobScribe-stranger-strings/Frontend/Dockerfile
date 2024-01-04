FROM node:21-alpine
EXPOSE 5173
WORKDIR /frontend
COPY . .
RUN npm i
CMD ["npm", "run", "dev"]