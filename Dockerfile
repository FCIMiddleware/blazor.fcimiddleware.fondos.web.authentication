#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#WORKDIR /app
#EXPOSE 8085
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#WORKDIR /src
#COPY ["src/blazor.fcimiddleware.fondos.web.authentication/blazor.fcimiddleware.fondos.web.authentication.csproj", "src/blazor.fcimiddleware.fondos.web.authentication/"]
#RUN dotnet restore "src/blazor.fcimiddleware.fondos.web.authentication/blazor.fcimiddleware.fondos.web.authentication.csproj"
#COPY . .
#WORKDIR "/src/src/blazor.fcimiddleware.fondos.web.authentication"
#RUN dotnet build "blazor.fcimiddleware.fondos.web.authentication.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "blazor.fcimiddleware.fondos.web.authentication.csproj" -c Release -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "blazor.fcimiddleware.fondos.web.authentication.dll"]

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/blazor.fcimiddleware.fondos.web.authentication/blazor.fcimiddleware.fondos.web.authentication.csproj", "src/blazor.fcimiddleware.fondos.web.authentication/"]
RUN dotnet restore "src/blazor.fcimiddleware.fondos.web.authentication/blazor.fcimiddleware.fondos.web.authentication.csproj"
COPY . .
RUN dotnet build "src/blazor.fcimiddleware.fondos.web.authentication/blazor.fcimiddleware.fondos.web.authentication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src/blazor.fcimiddleware.fondos.web.authentication/blazor.fcimiddleware.fondos.web.authentication.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf