# ASP.NET 7.0 project
## Technologies
- Docker
- ASP.NET 7.0
- Entity Framework Core 7.0
## Install Packages
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.Design
## How to configure and run
- Install Docker Destop
- Create network : `docker network create --scope=swarm --attachable -d overlay backend`
- Create volume : `docker volume create --name=sql-sever`
- Run docker-compose : `docker-compose up -d`
- Set startup project : `eShop.Data` and run `Update-Database` in Package Manager Console
- Api: `http://localhost:5001/swagger/index.html`
- AdminApp: `http://localhost:5002` (admin/Abc@12345)
- WebApp: `http://localhost:5003`
## References
- https://youtu.be/ImYt340wQxE?si=NYLPRQLJF0p2v7aa
## Template
- https://www.free-css.com/free-css-templates/page280/multishop
- https://startbootstrap.com/theme/sb-admin-2
