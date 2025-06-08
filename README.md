# StudentsAdminEditors

## Type: ASP.NET Core MVC template

## Database: SQLite (app.db)
## Authentication & Roles: ASP.NET Identity with role-based access (Admin / User)

Project Structure:
Models:
Student — represents student entity with basic properties (e.g., name, group).
ApplicationUser — extends IdentityUser to support role-based access.

Controllers:

StudentsController — handles CRUD operations for students.

ApplicationUsersController — displays registered users and their roles (read-only).

Views:

Razor views grouped into folders: Students, Home, ApplicationUsers.

Data Layer:

ApplicationDbContext — EF Core database context.

DbInitializer — seeds initial roles and admin user.

Services:

ImageService — handles image uploads and deletions for student profiles.

Repository — basic repository pattern for data access.

Interfaces: Common abstractions (IRepository, IImageService).

Mappings: AutoMapper profile to convert between domain models and view models.

Migrations: Initial EF Core migration to create the database schema.

ViewModels: Example: StudentViewModel used to bind student forms.

✅ Key Features:
Role-based authorization: only Admins can create/edit/delete students.

Image upload and removal for student profiles.

EF Core with SQLite using Code First and Migrations.

Clean folder structure for learning or reuse in other projects.

🔧 Use Case:
This project serves as a starter template for admin panels with Identity, role management, file uploads, and structured architecture — ideal for small admin dashboards or educational use.

![Screenshot 2025-06-08 180521](https://github.com/user-attachments/assets/bbe19664-ce2f-484a-90e8-688e483f8a37)

![Screenshot 2025-06-08 180411](https://github.com/user-attachments/assets/e51a0e1c-6661-4bab-a6cf-886361d69a15)

![Screenshot-2025-06-08-181707](https://github.com/user-attachments/assets/542101c7-7fb5-43d0-9a09-276e9b5ff8a4)

![Screenshot-2025-06-08-181732](https://github.com/user-attachments/assets/e5ba523e-b3f9-4f21-982a-ca34b8ea8ff8)

![Screenshot-2025-06-08-181751](https://github.com/user-attachments/assets/3b26d5d1-bbd4-43aa-b8e2-9c73f7f9ffd0)

![Screenshot-2025-06-08-181821](https://github.com/user-attachments/assets/39fd8087-34e5-49d7-a82e-acc40ca6f6e0)

![Screenshot-2025-06-08-181836](https://github.com/user-attachments/assets/c83e8edf-dc7f-4705-8692-54ced64b44e2)
