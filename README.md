# ASP.NET Core Identity & Role-Based Access Control (RBAC)

A robust and scalable Web Application built with **ASP.NET Core MVC** and **Entity Framework Core**, implementing complete Authentication, Authorization, Custom User Management, and Role-Based Access Control (RBAC).

---

## 🚀 Features

- **Custom User Model**: Extended `IdentityUser` with custom properties (`ApplicationUser`).
- **Authentication**: Secure Login, Registration, and Logout with password hashing and validation.
- **Automatic First-User Admin Assignment**: Automatically assigns the `Admin` role to the first registered user and `User` role to subsequent registrations.
- **Role Management**:
  - Create and Delete Roles dynamically from the Admin Panel.
  - View all registered users and their assigned roles.
  - Manage user roles with checkboxes (`ManageUserRoles`).
- **Dynamic UI Rendering**: Customized navigation bar (`_LoginPartial`) showing Admin Panel links conditionally based on user roles (`User.IsInRole("Admin")`).
- **Security & Authorization**: Protected endpoints using `[Authorize]` and `[Authorize(Roles = "Admin")]` attributes.
- **CSRF Protection**: Form-based `POST` logout implementation.

---

## 🛠️ Tech Stack & Libraries

- **Framework**: ASP.NET Core MVC (.NET 8/9)
- **Database Access**: Entity Framework Core, SQL Server
- **Identity Framework**: Microsoft.AspNetCore.Identity.EntityFrameworkCore
- **Frontend**: Razor Views, Bootstrap 5, jQuery



