# docker build -f docker/webapi/Dockerfile -t chat-copilot-webapi .

# builder
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS builder
WORKDIR /source
# generate dev-certs for https
RUN dotnet dev-certs https
# copy everything else and build app
COPY webapi webapi
COPY shared shared
RUN cd webapi && \
  dotnet restore --use-current-runtime && \
  dotnet publish --use-current-runtime --self-contained false --no-restore -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV Kestrel__Endpoints__Http__Url=http://0.0.0.0:8080
ENV Kestrel__Endpoints__Https__Url=https://0.0.0.0:40443
WORKDIR /app
COPY --from=builder /app .
COPY --from=builder /root/.dotnet/corefx/cryptography/x509stores/my/* /root/.dotnet/corefx/cryptography/x509stores/my/
ENTRYPOINT ["./CopilotChatWebApi"]
