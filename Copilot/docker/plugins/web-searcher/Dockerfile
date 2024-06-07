# docker build -f docker/plugins/web-searcher/Dockerfile -t web-searcher .

# builder
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS builder
WORKDIR /source
# copy everything else and build app
COPY plugins/web-searcher plugins/web-searcher
COPY plugins/shared plugins/shared
COPY shared shared
RUN cd plugins/web-searcher && \
  dotnet restore --use-current-runtime && \
  dotnet publish --use-current-runtime --self-contained false --no-restore -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV Kestrel__Endpoints__Http__Url=http://0.0.0.0:8080
WORKDIR /app
COPY --from=builder /app .
ENTRYPOINT ["./WebSearcher"]
