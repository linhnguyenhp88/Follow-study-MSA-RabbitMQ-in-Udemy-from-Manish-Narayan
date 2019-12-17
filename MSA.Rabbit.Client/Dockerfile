#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MSA.Rabbit.Client/MSA.Rabbit.Client.csproj", "MSA.Rabbit.Client/"]
RUN dotnet restore "MSA.Rabbit.Client/MSA.Rabbit.Client.csproj"
COPY . .
WORKDIR "/src/MSA.Rabbit.Client"
RUN dotnet build "MSA.Rabbit.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MSA.Rabbit.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MSA.Rabbit.Client.dll"]