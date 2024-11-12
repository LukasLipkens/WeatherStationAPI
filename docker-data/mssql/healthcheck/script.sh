#!/bin/bash

RESULT=$(/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$MSSQL_SA_PASSWORD" -C -Q "SELECT name FROM sys.databases WHERE name IN ('weatherstations_dev', 'weatherstations_prod')" -h -1)

if echo "$RESULT" | grep -q "weatherstations_dev" && echo "$RESULT" | grep -q "weatherstations_prod"; then
    echo "Both databases are present."
    exit 0  # Success exit code
else
    echo "One or both databases are missing."
    exit 1  # Failure exit code
fi
