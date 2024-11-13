FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["plugins/EmailSend/EmailSend.csproj", "plugins/EmailSend/"]
COPY ["plugins/shared/PluginShared.csproj", "plugins/shared/"]
RUN dotnet restore "plugins/EmailSend/EmailSend.csproj"
COPY . .
WORKDIR "/src/plugins/EmailSend"
RUN dotnet build "EmailSend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "EmailSend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmailSend.dll"]
