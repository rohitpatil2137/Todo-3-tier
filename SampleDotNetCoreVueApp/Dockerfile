# Use the appropriate base image for building .NET applications
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expose port 5000 (or whichever port your ASP.NET Core app is listening on)
EXPOSE 5000

# Command to run the application
ENTRYPOINT ["dotnet", "SampleDotNetCoreVueApp.dll"]
