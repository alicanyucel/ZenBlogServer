FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "Presentation/ZenBlogServer.Api/ZenBlogServer.Api.csproj"
RUN dotnet publish "Presentation/ZenBlogServer.Api/ZenBlogServer.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
ENTRYPOINT ["dotnet","ZenBlogServer.Api.dll"]
