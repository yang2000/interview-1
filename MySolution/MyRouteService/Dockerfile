#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/runtime:2.1-nanoserver-1803 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.1-nanoserver-1803 AS build
WORKDIR /src
COPY ["MyRouteService/MyRouteService.csproj", "MyRouteService/"]
COPY ["RouteServiceCommon/RouteServiceCommon.csproj", "RouteServiceCommon/"]
RUN dotnet restore "MyRouteService/MyRouteService.csproj"
COPY . .
WORKDIR "/src/MyRouteService"
RUN dotnet build "MyRouteService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MyRouteService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MyRouteService.dll"]