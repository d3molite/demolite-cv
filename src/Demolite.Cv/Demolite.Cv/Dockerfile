FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
ARG CERT_PASS
ENV CERT_PASS $CERT_PASS

RUN mkdir https
RUN dotnet dev-certs https -ep ./https/aspnetapp.pfx -p ${CERT_PASS}
RUN dotnet dev-certs https

WORKDIR /src
COPY ["Demolite.Cv/Demolite.Cv.csproj", "Demolite.Cv/"]
COPY ["Demolite.Cv.Common/Demolite.Cv.Common.csproj", "Demolite.Cv.Common/"]
COPY ["Demolite.Cv.Db/Demolite.Cv.Db.csproj", "Demolite.Cv.Db/"]
COPY ["Demolite.Cv.Interfaces/Demolite.Cv.Interfaces.csproj", "Demolite.Cv.Interfaces/"]
COPY ["Demolite.Cv.Services/Demolite.Cv.Services.csproj", "Demolite.Cv.Services/"]
COPY ["Demolite.Cv.Ui/Demolite.Cv.Ui.csproj", "Demolite.Cv.Ui/"]

RUN dotnet restore "Demolite.Cv/Demolite.Cv.csproj"
COPY . .
WORKDIR "/src/Demolite.Cv"
RUN dotnet build "./Demolite.Cv.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Demolite.Cv.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

COPY --chmod=0755 --from=build /https/* /https/
COPY --from=publish /app/publish .

RUN mkdir /app/db/

ENTRYPOINT ["dotnet", "Demolite.Cv.dll"]
