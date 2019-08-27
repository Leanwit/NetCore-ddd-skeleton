FROM microsoft/dotnet:2.2-sdk-alpine3.8 AS build

WORKDIR /home/app
 
COPY . .
 
RUN dotnet restore ./apps/mooc/backend/backend.csproj
 
RUN dotnet publish ./apps/mooc/backend/backend.csproj -o /publish/
 
WORKDIR /publish
 
ENTRYPOINT ["dotnet", "backend.dll", "--urls", "http://*:5000"]