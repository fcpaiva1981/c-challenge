# Use the official MySQL 8.0 image as the base image
FROM mysql:latest

# Set environment variables
ENV MYSQL_ROOT_PASSWORD=q1w2e3r4t5
ENV MYSQL_DATABASE=chsharpchallenge

# Copy the SQL scripts into the Docker container
COPY init.sql /docker-entrypoint-initdb.d/

# Expose port 3306 to allow external connections to the MySQL server
EXPOSE 3306
