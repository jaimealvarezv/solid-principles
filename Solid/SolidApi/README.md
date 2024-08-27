# Product Management API

This project demonstrates the implementation of a simple Product Management API using two different approaches: one following SOLID principles and another that does not. The API allows you to manage products with fields like ID, Name, Price, Photo URL, and Expiration Date.

## Project Structure

The project is divided into two separate implementations:

1. **NoSolid**: A basic implementation that does not follow SOLID principles.
2. **Solid**: An implementation that adheres to SOLID principles for better maintainability and scalability.

### NoSolid Implementation

This implementation places all logic directly in the controller, which handles everything from data access to business logic. While this approach may seem simpler, it often leads to tightly coupled code, making it harder to maintain and extend.

### Solid Implementation

The SOLID implementation separates concerns by adhering to the following principles:

- **S**ingle Responsibility Principle: Each class has only one responsibility.
- **O**pen/Closed Principle: Classes are open for extension but closed for modification.
- **L**iskov Substitution Principle: Derived classes should be substitutable for their base classes.
- **I**nterface Segregation Principle: No client should be forced to depend on methods it does not use.
- **D**ependency Inversion Principle: High-level modules should not depend on low-level modules; both should depend on abstractions.

This approach results in a more modular and testable codebase.

## Steps Followed to Implement SOLID

The following steps were taken to implement the SOLID principles in this project:

1. **Create Models**: 
   - The `Product` class was created in the `Models` directory to represent the product entity with fields like `Id`, `Name`, `Price`, `PhotoUrl`, and `ExpirationDate`.
   
2. **Create Interfaces**:
   - `IProductRepository`: An interface was created to define the contract for data access operations. This interface includes methods like `GetAll`, `GetById`, `Add`, `Update`, and `Delete`.
   - `IProductService`: This interface was created to define the contract for business logic operations. It interacts with the repository and includes similar methods to `IProductRepository`.

3. **Implement Repositories**:
   - `ProductRepository`: A class that implements `IProductRepository`. This class is responsible for managing data access, such as retrieving and storing product data. It acts as a layer between the data source (in this case, a simple in-memory list) and the business logic.

4. **Implement Services**:
   - `ProductService`: A class that implements `IProductService`. This class contains the business logic of the application. It uses the repository to retrieve, add, update, and delete products while applying any necessary business rules.

5. **Create Controllers**:
   - `ProductController`: The API controller class that handles HTTP requests and responses. It depends on `IProductService` to perform actions. By depending on an interface, the controller is decoupled from the concrete implementation, making it easier to modify or extend the service layer.

6. **Dependency Injection**:
   - The `Startup.cs` file was modified to configure dependency injection, ensuring that the correct implementations (`ProductRepository` and `ProductService`) are provided whenever the corresponding interfaces are requested by the application.

### Why Divide the Code into Multiple Classes?

Dividing the code into multiple classes each with a specific responsibility is crucial for achieving a modular, maintainable, and testable application. Here’s why:

- **Separation of Concerns**: Each class has a single responsibility, making the code easier to understand, maintain, and test. For example, `ProductRepository` handles data access, while `ProductService` handles business logic.
  
- **Flexibility**: By using interfaces like `IProductRepository` and `IProductService`, we can easily swap out implementations without affecting other parts of the application. This is aligned with the Open/Closed Principle.
  
- **Testability**: With clearly defined interfaces and separation of concerns, unit testing becomes easier. You can mock dependencies like `IProductRepository` when testing `ProductService`, isolating the functionality under test.

### Explanation of Class Names

- **`Product`**: Represents the domain entity that the API manages. It contains properties like `Id`, `Name`, `Price`, `PhotoUrl`, and `ExpirationDate` that define a product.
  
- **`IProductRepository`**: The `I` prefix indicates that this is an interface. It defines a contract for data access operations, meaning any class that implements this interface must provide implementations for these methods.
  
- **`ProductRepository`**: Implements `IProductRepository`. The name reflects its role in managing product data, adhering to the repository pattern, which separates the business logic from data access.
  
- **`IProductService`**: Similar to `IProductRepository`, this interface defines the contract for business logic operations related to products.
  
- **`ProductService`**: Implements `IProductService`. It contains business rules and logic that operate on the product data. The service layer is where the core functionality of the application resides.
  
- **`ProductController`**: The controller is responsible for handling HTTP requests. Its name indicates that it manages operations related to products, delegating business logic to `ProductService`.

## Installation and Setup

### Prerequisites

- .NET Core 8.0 SDK
- Visual Studio Code
- [REST Client Extension](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) for Visual Studio Code

### Steps to Run the Project

1. **Clone the Repository**

   ```bash
   git clone <repository-url>
   cd ProductManagementApi

## Swagger Documentation

The Swagger documentation for this API is available at the following URL: [http://localhost:5009/index.html](http://localhost:5009/index.html)