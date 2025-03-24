# Use the official .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Copy project files
COPY *.csproj ./
RUN dotnet restore

# Copy the entire project and publish it
COPY . ./
RUN dotnet publish -c Release -o out

# Use the runtime image to serve the application
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .

# Expose port 80 for web traffic
EXPOSE 80

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "Movie-e-commerce-website.dll"]
