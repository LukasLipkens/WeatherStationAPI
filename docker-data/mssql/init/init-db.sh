#!/bin/bash

# Start sql serve
/opt/mssql/bin/sqlservr &

# Wait for SQL Server to start by checking the status
echo "Waiting for SQL Server to start..."
until /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$MSSQL_SA_PASSWORD" -C -Q "SELECT 1" &> /dev/null; do
    sleep 1
done
echo "SQL Server is up. Proceeding with database setup."

# Create databases
/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$MSSQL_SA_PASSWORD" -C -Q "
CREATE DATABASE [${DB_NAME}_prod];
CREATE DATABASE [${DB_NAME}_dev];
"

# Wait for database creation and startup
sleep 3

# Add logins
/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$MSSQL_SA_PASSWORD" -C -Q "
CREATE LOGIN [$DB_USER_R] WITH PASSWORD='$DB_USER_R_PASSWORD';
CREATE LOGIN [$DB_USER_RW] WITH PASSWORD='$DB_USER_RW_PASSWORD';
"

# Add users with perms to prod databases
/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$MSSQL_SA_PASSWORD" -C -Q "
USE [${DB_NAME}_prod];
CREATE USER [$DB_USER_R] FOR LOGIN [$DB_USER_R];
ALTER ROLE db_datareader ADD MEMBER [$DB_USER_R];
CREATE USER [$DB_USER_RW] FOR LOGIN [$DB_USER_RW];
ALTER ROLE db_datawriter ADD MEMBER [$DB_USER_RW];
"

# Add users with perms to dev databases
/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$MSSQL_SA_PASSWORD" -C -Q "
USE [${DB_NAME}_dev];
CREATE USER [$DB_USER_R] FOR LOGIN [$DB_USER_R];
ALTER ROLE db_datareader ADD MEMBER [$DB_USER_R];
CREATE USER [$DB_USER_RW] FOR LOGIN [$DB_USER_RW];
ALTER ROLE db_datawriter ADD MEMBER [$DB_USER_RW];
"

# Wait to keep the container running
wait
