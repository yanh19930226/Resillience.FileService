FROM registry.cn-hangzhou.aliyuncs.com/yoyosoft/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM registry.cn-hangzhou.aliyuncs.com/yoyosoft/dotnet/core/sdk AS build
WORKDIR /src

COPY ["NuGet.Config", "src/NuGet.Config"]
COPY ["src/Resillience.FileService.Api/Resillience.FileService.Api.csproj", "src/Resillience.FileService.Api/"]
COPY ["src/Resillience.FileService.Authorization/Resillience.FileService.Authorization.csproj", "src/Resillience.FileService.Authorization/"]
COPY ["src/Resillience.FileService.Db/Resillience.FileService.Db.csproj", "src/Resillience.FileService.Db/"]
COPY ["src/Resillience.FileService.Service/Resillience.FileService.Service.csproj", "src/Resillience.FileService.Service/"]
RUN dotnet restore  --configfile "src/NuGet.Config" "src/Resillience.FileService.Api/Resillience.FileService.Api.csproj"

COPY . .
WORKDIR "/src/src/Resillience.FileService.Api"
RUN dotnet build "Resillience.FileService.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Resillience.FileService.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Resillience.FileService.Api.dll"]