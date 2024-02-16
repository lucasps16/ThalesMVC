# ThalesMVC

ThalesMVC is a full-stack web application developed using Visual Studio 2022, .NET 8, and Angular 17.1.3.

## Table of Contents

- [Overview](#overview)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Running the application](#Running-the-application)

## Overview

ThalesMVC is a web application built with .NET 8 on the backend and Angular 17.1.3 on the frontend. The project is structured to separate the backend, frontend, and unit tests into distinct folders.

## Project Structure

The repository consists of the following folders:

- **ThalesMVCAngular.Server**: Contains the .NET 8 MVC application.
- **thalesmvcangular.client**: Houses the Angular 17.1.3 application for the frontend user interface.
- **ThalesMVCAngular.ServerTest**: Includes unit tests.

## Getting Started

### Prerequisites

Ensure you have the following tools installed on your machine:

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://cli.angular.io/)

### Running the application

1. Clone the repository.
2. Open **ThalesMVCAngular.sln** with Visual Studio 2022.
3. On the Visual Studio Navbar, select **ThalesMVCAngular.Server** and click the **Run** button.
   ![image](https://github.com/lucasps16/ThalesMVC/assets/36195155/7bfae462-685f-47c0-b8b0-57c3203a2641)
4. Multiple windows will open on the default browser of your computer.

   **Swagger**: Shows all the available API calls and can be tested.
       ![image](https://github.com/lucasps16/ThalesMVC/assets/36195155/e061cbd6-6f34-47fc-8077-90e0f98337d7)

   **Thales App**: Application UI
       ![image](https://github.com/lucasps16/ThalesMVC/assets/36195155/3118238b-9b3c-47bf-b6cf-3de7c63d0d39)

      Clicking on the Employees button on the navbar will take you to the Employees page where all the employees information is displayed on a table.
       ![image](https://github.com/lucasps16/ThalesMVC/assets/36195155/6c451274-8e82-4b43-82e1-91f4056a58b7)

      Searching by id of an employee will return only the information of said employee.

      **PD:** As the API used is public and used for testing, sometimes it will return a "Too Many Request" response, when this happens the table will be empty.
5. To run the unit test go to the Visual Studio Solution Explorer and right click on ThalesMVCAngular.ServerTest, then click on "Run Test". The tests will run automatically.
     ![image](https://github.com/lucasps16/ThalesMVC/assets/36195155/34cc6c9a-074f-40c4-a8c6-d13385378cfa)

       

 

