FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UsersForumService/UsersForumService.csproj", "UsersForumService/"]
COPY ["UsersForumService.DAL/UsersForumService.DAL.csproj", "UsersForumService.DAL/"]
RUN dotnet restore "UsersForumService/UsersForumService.csproj"
COPY . .
RUN dotnet publish "UsersForumService/UsersForumService.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "UsersForumService.dll"]
