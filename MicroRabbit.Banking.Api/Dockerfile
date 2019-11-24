FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MicroRabbit.Banking.Api/MicroRabbit.Banking.Api.csproj", "MicroRabbit.Banking.Api/"]
RUN dotnet restore "MicroRabbit.Banking.Api/MicroRabbit.Banking.Api.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Banking.Api"
RUN dotnet build "MicroRabbit.Banking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroRabbit.Banking.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroRabbit.Banking.Api.dll"]