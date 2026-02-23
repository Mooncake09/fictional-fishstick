FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["EcomMSA.Catalog.Service.csproj", "."]
RUN dotnet restore "EcomMSA.Catalog.Service.csproj"
COPY . .
RUN dotnet publish "EcomMSA.Catalog.Service.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
RUN mkdir -p /app/Data/SQLite && chmod 755 /app/Data/SQLite
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "EcomMSA.Catalog.Service.dll"]