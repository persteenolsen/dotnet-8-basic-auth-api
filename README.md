# dotnet-8-basic-auth

.NET 8.0 - Basic HTTP Authentication API

# Last updated

- 23-04-2024

# Creates a global json

dotnet new globaljson --sdk-version 8.0.203 --force

# Functionality of the Web App

- BASIC HTTP authentication

# Tech used for creating the Web App

- A .NET 8 Web API
- A Blazor Webassembly Web Client for the frontend
- A Vue 3 Client for the Frontend
- A traditional Webhotel for hosting
- VS Code

# Development

dotnet run

# Production

Create a self contained build for production at the remote server / traditionel web hotel

dotnet publish webapi.csproj --configuration Release --runtime win-x86 --self-contained

Upload the build to remote server

At my remote servers the web.config needs to be without the folowing:

hostingModel="inprocess"



