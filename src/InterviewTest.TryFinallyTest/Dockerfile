FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ServiceChannelInterview.TryFinallyTest/ServiceChannelInterview.TryFinallyTest.csproj", "ServiceChannelInterview.TryFinallyTest/"]
RUN dotnet restore "ServiceChannelInterview.TryFinallyTest/ServiceChannelInterview.TryFinallyTest.csproj"
COPY . .
WORKDIR "/src/ServiceChannelInterview.TryFinallyTest"
RUN dotnet build "ServiceChannelInterview.TryFinallyTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceChannelInterview.TryFinallyTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServiceChannelInterview.TryFinallyTest.dll"]
