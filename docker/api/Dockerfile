FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app/api

COPY /api .

RUN dotnet restore "api.csproj"

ENTRYPOINT ["dotnet", "watch", "run", "--urls", "http://dotnet:80"]