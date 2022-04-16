FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ServichannelInterview.Console1/ServichannelInterview.Console1.csproj", "ServichannelInterview.Console1/"]
RUN dotnet restore "ServichannelInterview.Console1/ServichannelInterview.Console1.csproj"
COPY . .
WORKDIR "/src/ServichannelInterview.Console1"
RUN dotnet build "ServichannelInterview.Console1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServichannelInterview.Console1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServichannelInterview.Console1.dll"]
