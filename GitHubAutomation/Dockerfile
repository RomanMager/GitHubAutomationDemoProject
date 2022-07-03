FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GitHubAutomation/GitHubAutomation.csproj", "GitHubAutomation/"]
RUN dotnet restore "GitHubAutomation/GitHubAutomation.csproj"
COPY . .
WORKDIR "/src/GitHubAutomation"
RUN dotnet build "GitHubAutomation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GitHubAutomation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GitHubAutomation.dll"]
