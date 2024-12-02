# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .

# Restaurar pacotes
RUN dotnet restore "./src/DesafioBookStore-Back.Presentation/DesafioBookStore-Back.Presentation.csproj"

# Compilar o projeto da API
RUN dotnet build "./src/DesafioBookStore-Back.Presentation/DesafioBookStore-Back.Presentation.csproj" -c Release -o /app/build

# Publicar a aplicação
FROM build AS publish
RUN dotnet publish "./src/DesafioBookStore-Back.Presentation/DesafioBookStore-Back.Presentation.csproj" -c Release -o /app/publish

# Etapa de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "DesafioBookStore-Back.Presentation.dll"]
