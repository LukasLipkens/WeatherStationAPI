#!/bin/bash

# Make sure the scripts have the correct line endings
sed -i 's/\r$//' /init/init-db.sh
sed -i 's/\r$//' /healthcheck/script.sh

# Make sure the scripts are executable
chmod +x /init/init-db.sh
chmod +x /healthcheck/script.sh

# Start the SQL serve
/opt/mssql/bin/sqlservr &

# Run init db script
/init/init-db.sh

# Wait to keep the container running
wait
