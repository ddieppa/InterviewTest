FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ServichannelInterview.Closure/ServichannelInterview.Closure.csproj", "ServichannelInterview.Closure/"]
RUN dotnet restore "ServichannelInterview.Closure/ServichannelInterview.Closure.csproj"
COPY . .
WORKDIR "/src/ServichannelInterview.Closure"
RUN dotnet build "ServichannelInterview.Closure.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServichannelInterview.Closure.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServichannelInterview.Closure.dll"]
