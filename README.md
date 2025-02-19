# Product Organiser Web Application

## Overview

This is a web application built with **ASP.NET Core** and **MySQL** for managing products. It allows users to **add, list, view, and delete** products with a relational database.

## Features

- **Add Products**: Users can add products with Name, Description, Quantity, and Price.
- **List Products**: Displays all products sorted by name.
- **View Product Details**: Shows full information on a selected product.
- **Delete Products**: Removes a product and updates the list.

## Installation and Setup

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [MySQL](https://dev.mysql.com/downloads/)
- Any C# IDE (e.g., [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/))

### Steps

1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/your-repository.git
2. Navigate to the project directory:
   ```sh
   cd your-project-folder
3. Configure database connection in appsettings.json:
   ```json
   {  "ConnectionStrings": {
    "DefaultConnection": "server=your_server;database=your_database;user=your_user;password=your_password;"} }
4. Apply database migrations:
   ```sh
   dotnet ef database update
5. Run the application:
   ```sh
   dotnet run
6. Open in a browser: http://localhost:5000

## Project Structure
```bash
/your-project-folder
│── Controllers/
│   ├── HomeController.cs
│   ├── ProductsController.cs
│
│── Models/
│   ├── Product.cs
│   ├── ErrorViewModel.cs
│
│── Data/
│   ├── AppDbContext.cs
│
│── Views/
│── wwwroot/
│── Program.cs
│── appsettings.json
│── README.md
```
# Key Components

## Models

### `Product.cs`
Defines the product model with:
- `Id` (Primary Key)
- `Name`, `Description` (Required)
- `Quantity`, `Price` (Non-negative values)

## Controllers

### `HomeController.cs`
Handles basic routes:
- `Index()`
- `Privacy()`
- `Error()`

### `ProductsController.cs`
Handles CRUD operations:
- `Index()` – Shows the three cheapest products.
- `List()` – Lists all products alphabetically.
- `Details(int id)` – Displays product info.
- `Add()` – Handles adding products.
- `Delete(int id)` – Removes a product.

## Database Context

### `AppDbContext.cs`
Manages database operations via **Entity Framework Core**.

## Routing

Defined in `Program.cs` to set the default controller.

## Important Features

- **Model Validation**: Ensures required fields are filled and valid.
- **Asynchronous Methods**: Improves performance in database operations.
- **Error Handling**: Managed through `ErrorViewModel.cs`.

## Future Improvements

- Implement **search functionality** for products.
- Add **authentication and user roles**.
- Improve **UI/UX** with better design.

## License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

## Contributions

Feel free to submit a pull request if you find any issues or want to improve this project. 🚀


   
