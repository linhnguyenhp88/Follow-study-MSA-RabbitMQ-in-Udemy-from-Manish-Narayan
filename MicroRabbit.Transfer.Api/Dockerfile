FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MicroRabbit.Transfer.Api/MicroRabbit.Transfer.Api.csproj", "MicroRabbit.Transfer.Api/"]
RUN dotnet restore "MicroRabbit.Transfer.Api/MicroRabbit.Transfer.Api.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Transfer.Api"
RUN dotnet build "MicroRabbit.Transfer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroRabbit.Transfer.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroRabbit.Transfer.Api.dll"]