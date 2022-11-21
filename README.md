# EFCore Testbed

For iterating on EFCore ideas.

## Docker

```bash
docker run -d \
    -p 9401:1433 \
    -e ACCEPT_EULA=1 \
    -e MSSQL_SA_PASSWORD="LocalDev#333" \
    --cap-add=SYS_PTRACE \
    --name local_dev_sql \
    mcr.microsoft.com/azure-sql-edge:latest
```

