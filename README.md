# Course Management System API

This is a Web API built with .NET 8 for managing Courses and Students.

## Features
- **Models:** Course and Student with a One-to-Many relationship.
- **Service Layer:** All logic is handled in `CourseService`.
- **Security:** Endpoints are protected with `[Authorize]`.

## Endpoints
- `GET /api/courses` - Get all courses.
- `POST /api/courses` - Add a new course (Requires Validation).
- `GET /api/students` - Get all students.

## How to Run
1. Clone the repo.
2. Run `dotnet run`.
3. Open `http://localhost:5000/swagger` to test the endpoints.
