FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["OrderMicroService.csproj", "./"]
RUN dotnet restore "./OrderMicroService.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "OrderMicroService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OrderMicroService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrderMicroService.dll"]
