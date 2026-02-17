# Changelog

All notable changes to this project will be documented in this file.

## [1.0.0] - 2026-02-16
### Added
- Initial project structure with ASP.NET Core Web API.
- Entity Framework Core with SQLite database support.
- `Customer` entity model and `CustomerDto` for data transfer.
- Database Migrations and Data Seeding (Initial data).
- CRUD Endpoints in `CustomersController`:
  - `GET /api/Customers` (Get all data)
  - `GET /api/Customers/{id}` (Get single data)
  - `POST /api/Customers` (Create new data)
  - `PUT /api/Customers/{id}` (Update existing data)
  - `DELETE /api/Customers/{id}` (Delete data)
- Swagger UI for API testing.

### Fixed
- Resolved build errors in `CustomerDto` (added missing properties).
- Fixed Controller response types to strictly use DTOs.