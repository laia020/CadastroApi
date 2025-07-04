FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /app

COPY Cadastro.Api/Cadastro.Api.csproj ./Cadastro.Api/
RUN dotnet restore ./Cadastro.Api/Cadastro.Api.csproj

COPY . ./

RUN dotnet publish Cadastro.Api/Cadastro.Api.csproj -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
WORKDIR /app

# Copia arquivos publicados
COPY --from=build /app/out ./

# Garante permissão de escrita para o SQLite
RUN touch dev.db && chmod 666 dev.db

# Define a porta de escuta via variável de ambiente
ENV ASPNETCORE_URLS=http://+:3000
EXPOSE 3000

ENTRYPOINT ["dotnet", "Cadastro.Api.dll"]
