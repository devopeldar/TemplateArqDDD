#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 4990

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TemplateArqDDD.Servicio.WebApi/TemplateArqDDD.Servicio.WebApi.csproj", "TemplateArqDDD.Servicio.WebApi/"]
COPY ["TemplateArqDDD.Aplicacion.Interface/TemplateArqDDD.Aplicacion.Interface.csproj", "TemplateArqDDD.Aplicacion.Interface/"]
COPY ["TemplateArqDDD.Transversal.Common/TemplateArqDDD.Transversal.Common.csproj", "TemplateArqDDD.Transversal.Common/"]
COPY ["TemplateArqDDD.Aplicacion.Entidad/TemplateArqDDD.Aplicacion.Entidad.csproj", "TemplateArqDDD.Aplicacion.Entidad/"]
COPY ["TemplateArqDDD.Dominio.Core/TemplateArqDDD.Dominio.Core.csproj", "TemplateArqDDD.Dominio.Core/"]
COPY ["TemplateArqDDD.Dominio.Interface/TemplateArqDDD.Dominio.Interface.csproj", "TemplateArqDDD.Dominio.Interface/"]
COPY ["TemplateArqDDD.Dominio.Entidad/TemplateArqDDD.Dominio.Entidad.csproj", "TemplateArqDDD.Dominio.Entidad/"]
COPY ["TemplateArqDDD.Infraestructura.Interface/TemplateArqDDD.Infraestructura.Interface.csproj", "TemplateArqDDD.Infraestructura.Interface/"]
COPY ["TemplateArqDDD.Infraestructura.Core/TemplateArqDDD.Infraestructura.Core.csproj", "TemplateArqDDD.Infraestructura.Core/"]
COPY ["TemplateArqDDD.Aplicacion.Core/TemplateArqDDD.Aplicacion.Core.csproj", "TemplateArqDDD.Aplicacion.Core/"]
COPY ["TemplateArqDDD.Infraestructura.Entidad/TemplateArqDDD.Infraestructura.Entidad.csproj", "TemplateArqDDD.Infraestructura.Entidad/"]
COPY ["TemplateArqDDD.Transversal.Mapper/TemplateArqDDD.Transversal.Mapper.csproj", "TemplateArqDDD.Transversal.Mapper/"]
RUN dotnet restore "TemplateArqDDD.Servicio.WebApi/TemplateArqDDD.Servicio.WebApi.csproj"
COPY . .
WORKDIR "/src/TemplateArqDDD.Servicio.WebApi"
RUN dotnet build "TemplateArqDDD.Servicio.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TemplateArqDDD.Servicio.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TemplateArqDDD.Servicio.WebApi.dll"]

#docker image build -t devopeldar/templatearqddd4990:1.0.0 -f "TemplateArqDDD.Servicio.WebApi\Dockerfile" .
#docker push devopeldar/TemplateArqDDD4990:1.0.0