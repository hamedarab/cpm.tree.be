#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["cpm.tree.WebAppMvcMsIdentity/cpm.tree.WebAppMvcMsIdentity.csproj", "cpm.tree.WebAppMvcMsIdentity/"]
RUN dotnet restore "cpm.tree.WebAppMvcMsIdentity/cpm.tree.WebAppMvcMsIdentity.csproj"
COPY . .
WORKDIR "/src/cpm.tree.WebAppMvcMsIdentity"
RUN dotnet build "cpm.tree.WebAppMvcMsIdentity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cpm.tree.WebAppMvcMsIdentity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cpm.tree.WebAppMvcMsIdentity.dll"]