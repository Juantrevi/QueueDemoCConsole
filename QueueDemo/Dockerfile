FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["QueueDemo/QueueDemo.csproj", "QueueDemo/"]
RUN dotnet restore "QueueDemo/QueueDemo.csproj"
COPY . .
WORKDIR "/src/QueueDemo"
RUN dotnet build "QueueDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QueueDemo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QueueDemo.dll"]
