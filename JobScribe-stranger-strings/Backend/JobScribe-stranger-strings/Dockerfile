FROM mcr.microsoft.com/dotnet/sdk:7.0 AS base
WORKDIR /app
EXPOSE 5225

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["JobScribe-stranger-strings.csproj", "."]
RUN dotnet restore "JobScribe-stranger-strings.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "JobScribe-stranger-strings.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JobScribe-stranger-strings.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JobScribe-stranger-strings.dll"]

ENV ASPNETCORE_URLS=http://+:5225
