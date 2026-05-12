# Online Book Store Application

## Project Overview

The Online Book Store Application is a full-featured ASP.NET Core project developed using both MVC and Razor Pages. The application demonstrates advanced ASP.NET Core concepts including custom validations, filters, routing, session management, dependency injection, and repository pattern implementation.


---

# Features Implemented

## 1. Book Management System

- Add new books using Razor Pages
- Display all books using MVC
- View individual book details
- Custom validation for:
  - ISBN format
  - Price range

---
 
## 2. User Authentication & Authorization

- User login functionality
- Session-based authentication
- Custom authentication filter
- Restricted access handling

---

## 3. Shopping Cart & Order Processing

- Add books to cart
- View shopping cart
- Session management for cart items
- Order summary page
- Order confirmation page

---

## 4. Custom Validations & Filters

### Custom Validations
- ISBN Validation
- Price Validation

### Custom Filters
- Authentication Filter
- Global Exception Filter

---

## 5. Advanced Routing & Best Practices

- Custom routing for book details
- Repository Pattern implementation
- Dependency Injection
- Separation of concerns
- Maintainable project structure

---

# Technologies Used

- ASP.NET Core MVC
- Razor Pages
- C#
- .NET 8
- Session Management
- Dependency Injection
- Repository Pattern

---

# Project Structure

```text
OnlineBookStoreMVC
│
├── Controllers
│   ├── BookController.cs
│   ├── CartController.cs
│   └── OrderController.cs
│
├── Models
│   ├── Book.cs
│   ├── CartItem.cs
│   └── User.cs
│
├── Repositories
│   ├── IBookRepository.cs
│   └── BookRepository.cs
│
├── Validations
│   ├── ISBNValidationAttribute.cs
│   └── PriceValidationAttribute.cs
│
├── Filters
│   ├── AuthFilter.cs
│   └── GlobalExceptionFilter.cs
│
├── Pages
│   ├── Login.cshtml
│   ├── Login.cshtml.cs
│   │
│   └── Books
│       ├── AddBook.cshtml
│       └── AddBook.cshtml.cs
│
├── Views
│   ├── Book
│   │   ├── Index.cshtml
│   │   └── Details.cshtml
│   │
│   ├── Cart
│   │   └── ViewCart.cshtml
│   │
│   └── Order
│       ├── Summary.cshtml
│       └── Confirmation.cshtml
│
├── wwwroot
│
├── Program.cs
│
└── appsettings.json
```

---

# Routing

## Default Route

```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Book}/{action=Index}/{id?}");
```

## Custom Route

```csharp
app.MapControllerRoute(
    name: "bookdetails",
    pattern: "books/{id:int}",
    defaults: new
    {
        controller = "Book",
        action = "Details"
    });
```

---

# Session Management

Session management is implemented using ASP.NET Core Session Middleware for:

- User authentication
- Shopping cart tracking
- Maintaining user state across requests

---

# Filters Used

## Authentication Filter
Used to restrict unauthorized access.

## Global Exception Filter
Used for centralized exception handling and logging.

---

# Validation Used

## ISBN Validation
Ensures the ISBN contains 13 digits.

## Price Validation
Ensures the price is within the allowed range.

---

# Best Practices Followed

- Repository Pattern
- Dependency Injection
- Separation of Concerns
- Reusable Components
- Custom Validations
- Centralized Error Handling
- Maintainable Folder Structure

---

# How to Run the Project

1. Open the project in Visual Studio 2022
2. Restore NuGet packages
3. Build the solution
4. Run the application using:

```text
Ctrl + F5
```

5. Open browser and navigate to:

```text
https://localhost:xxxx/Book
```

---

# Application Pages

## MVC Pages

- `/Book`
- `/Book/Details/1`
- `/Cart/ViewCart`
- `/Order/Summary`
- `/Order/Confirmation`

## Razor Pages

- `/Books/AddBook`
- `/Login`

---

# Assignment Outcome

This project demonstrates:

- ASP.NET Core MVC
- Razor Pages
- Session Management
- Routing
- Filters
- Custom Validation
- Dependency Injection
- Repository Pattern
- Clean Application Architecture

---
