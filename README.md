# Orbit — Learning Management System

**Orbit** is a learning management platform designed to connect teachers and students in a centralized digital learning environment. The platform aims to simplify course management, assignment distribution, student collaboration, and feedback.

## Overview

Orbit provides a foundation for managing educational workflows, allowing teachers to organize courses and assignments while students can access learning materials, submit work, and communicate through comments.

The project is being developed with a focus on backend architecture, secure authentication, relational data modeling, and maintainable full-stack development.

## Planned Features

- **User Management** — separate roles and workflows for teachers and students.
- **Authentication & Authorization** — JWT-based authentication and role-based access control.
- **Course Management** — create, update, and manage courses.
- **Assignment Management** — publish assignments, set deadlines, and track student submissions.
- **Comments & Feedback** — enable communication between teachers and students around assignments.
- **Student Enrollment** — associate students with courses.
- **Data Persistence** — store users, courses, assignments, and related data in a relational database.

## Tech Stack

| Technology            | Purpose                                      |
| --------------------- | -------------------------------------------- |
| C#                    | Primary backend programming language         |
| ASP.NET Core          | Backend API and HTTP request handling        |
| Entity Framework Core | ORM and database access                      |
| Angular               | Frontend application                         |
| JWT                   | Authentication and token-based authorization |
| BCrypt                | Secure password hashing                      |
| Pino                  | Structured application logging               |
| Docker                | Containerization and deployment              |

## Architecture

Orbit is designed around a client-server architecture.

```text
Angular Frontend
       |
       | HTTP / JSON
       v
ASP.NET Core Web API
       |
       +-- Authentication & Authorization
       +-- Controllers
       +-- Business Logic
       +-- Entity Framework Core
       |
       v
Relational Database
```

The backend is responsible for request validation, access control, business rules, and data persistence. The Angular frontend provides the user interface and communicates with the API over HTTP.

## Domain Model

The planned core entities include:

- **User** — account information and user role.
- **Course** — course details and teacher ownership.
- **Enrollment** — the relationship between students and courses.
- **Assignment** — tasks associated with a course, including descriptions and deadlines.
- **Submission** — student work submitted for an assignment.
- **Comment** — discussion and feedback associated with relevant learning resources or submissions.

The data model will enforce relationships between entities and support role-specific permissions.

## Security

Security is an important part of the development process.

- Passwords are hashed using BCrypt rather than stored as plaintext.
- JWTs are used to authenticate API requests.
- Authorization rules restrict access to protected resources.
- Input validation helps prevent invalid data from entering the system.
- Database access is handled through Entity Framework Core.

## Development & Deployment

Docker is planned to provide a consistent development and deployment environment.

The application is intended to evolve toward a containerized setup that simplifies local development and makes the environment easier to reproduce.

## Project Status

**In Development**

The project is currently focused on establishing the backend foundation, configuring database access, and developing the core educational domain. The frontend and additional learning workflows are planned as the platform evolves.

## Roadmap

- [ ] Configure the ASP.NET Core Web API.
- [ ] Implement Entity Framework Core data access.
- [ ] Design the core database schema and relationships.
- [ ] Implement registration, login, and JWT authentication.
- [ ] Add teacher and student roles with authorization policies.
- [ ] Implement course creation and enrollment.
- [ ] Implement assignment creation and student submissions.
- [ ] Add comments and feedback workflows.
- [ ] Build the Angular frontend.
- [ ] Configure structured logging with Pino.
- [ ] Containerize the application with Docker.
- [ ] Add automated tests and API documentation.

## License

The project is currently under development. Licensing details will be added later.
