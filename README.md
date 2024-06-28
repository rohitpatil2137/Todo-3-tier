
```markdown
# SampleDotNetCoreVueApp

This is a sample application that demonstrates a Todo list with a .NET Core 6 backend and a Vue.js frontend. The frontend is built using Node.js and Vue.js, while the backend is built using ASP.NET Core 6.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Backend Setup](#backend-setup)
- [Frontend Setup](#frontend-setup)
- [Running the Application](#running-the-application)
- [Running the Application with Docker](#running-the-application-with-docker)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)

## Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Node.js](https://nodejs.org/) (version 14.x or higher)
- [Vue CLI](https://cli.vuejs.org/) (optional, for Vue.js development)
- [Docker](https://www.docker.com/)

## Backend Setup

1. Clone the repository:

   ```sh
   git clone https://github.com/rohitpatil2137/SampleDotNetCoreVueApp.git
   cd SampleDotNetCoreVueApp
   ```

2. Navigate to the backend project directory:

   ```sh
   cd backend
   ```

3. Restore the .NET dependencies:

   ```sh
   dotnet restore
   ```

4. Run the backend application:

   ```sh
   dotnet run
   ```

   The backend should now be running on `http://localhost:5000`.

## Frontend Setup

1. Navigate to the frontend project directory:

   ```sh
   cd frontend
   ```

2. Install the Node.js dependencies:

   ```sh
   npm install
   ```

3. Run the frontend application:

   ```sh
   npm run serve
   ```

   The frontend should now be running on `http://localhost:8080`.

## Running the Application

1. Start the backend server as described in the [Backend Setup](#backend-setup) section.
2. Start the frontend server as described in the [Frontend Setup](#frontend-setup) section.
3. Open your browser and navigate to `http://localhost:8080` to see the application in action.

## Running the Application with Docker

### Prerequisites

- Docker and Docker Compose must be installed.

### Steps

1. Clone the repository:

   ```sh
   git clone https://github.com/rohitpatil2137/SampleDotNetCoreVueApp.git
   cd SampleDotNetCoreVueApp
   ```

2. Build and run the Docker containers:

   ```sh
   docker-compose up --build
   ```

   This command will build the Docker images for both the backend and frontend and start the containers.

3. Open your browser and navigate to `http://localhost:8080` to see the application running.


## Technologies Used

- **Backend**:
  - ASP.NET Core 6
  - Entity Framework Core

- **Frontend**:
  - Vue.js 3
  - Vue Router
  - Axios

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request. We welcome all contributions!
