# NoSolidApi

This API was created as an example of an implementation that does not follow the SOLID principles. Below are some of the advantages and disadvantages of this approach.

## Disadvantages of Not Following SOLID

1. **Lack of Single Responsibility Principle (SRP)**:
   - The `ProductsController` handles multiple responsibilities, such as managing the product list, validation, and business logic. This makes the code harder to maintain and modify.

2. **Tightly Coupled Dependencies**:
   - The methods within the controller directly depend on a static list of products. This makes it difficult to change the data source (e.g., moving storage logic to a database).

3. **Difficulty in Unit Testing**:
   - Due to the coupling between business logic and the API, it's difficult to perform unit testing. Isolating parts of the code for testing without running the entire application is challenging.

4. **Violation of the Dependency Inversion Principle (DIP)**:
   - The API depends on a concrete implementation (the static product list) rather than depending on an abstraction. This reduces the flexibility of the code.

5. **No Interfaces to Define Contracts**:
   - No interfaces are used to define contracts that other classes could implement. This makes it difficult to change or extend the system's behavior without modifying existing code.

## Advantages

- **Initial Simplicity**:
  - The code is initially easier to understand and write, as there's no need to think about abstracting responsibilities or adhering to design principles.

- **Less Overhead for Small Projects**:
  - In very small projects, where evolution and change are limited, avoiding over-engineering can be an advantage.

## Instructions to Run the Project

### Prerequisites

1. **.NET 8 SDK**: Make sure you have the .NET 8 SDK installed. You can download it from [here](https://dotnet.microsoft.com/download/dotnet/8.0).
2. **Visual Studio Code**: It's recommended to use Visual Studio Code (VS Code) as your IDE. Download it [here](https://code.visualstudio.com/).
3. **C# Extension for Visual Studio Code**: Install the C# extension in VS Code for better support.
4. **.NET Core API Client Extension for VS Code**: This extension allows you to easily test APIs directly from VS Code. Install it from the Extensions view (`Ctrl+Shift+X`) by searching for `REST Client`.

### Steps to Run the API

1. **Clone the Repository** (or download the project files):
   ```bash
   git clone <repository-url>
   cd NoSolidApi


## Swagger Documentation

The Swagger documentation for this API is available at the following URL: [http://localhost:5137/index.html](http://localhost:5137/index.html)
