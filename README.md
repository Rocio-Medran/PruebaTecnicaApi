# API REST - Prueba Técnica

Este proyecto es una API REST desarrollada en ASP.NET Core que gestiona productos y categorías.

## Tecnologías utilizadas

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- AutoMapper
- Swagger para documentación
- Patrón Repository + Service

## Estructura del proyecto

- **Entities**: Contiene las clases `Producto` y `Categoria`.
- **DTOs**: Define objetos para transferencia de datos (Create, Update, Get).
- **Repositories**: Encapsulan el acceso a datos.
- **Services**: Lógica de negocio.
- **Controllers**: Exponen endpoints REST.
- **Mapping**: AutoMapper para convertir entre entidades y DTOs.

## Endpoints disponibles

### Productos
- `GET /api/productos` - Obtener todos los productos
- `GET /api/productos/{id}` - Obtener producto por ID
- `POST /api/productos` - Crear producto
- `PUT /api/productos/{id}` - Actualizar producto
- `DELETE /api/productos/{id}` - Eliminar producto

### Categorías
- `GET /api/categorias` - Obtener todas las categorías
- `GET /api/categorias/{id}` - Obtener categoría por ID
- `POST /api/categorias` - Crear categoría
- `PUT /api/categorias/{id}` - Actualizar categoría
- `DELETE /api/categorias/{id}` - Eliminar categoría

## Validaciones

- Se usan Data Annotations como `[Required]`, `[MaxLength]`, `[StringLength]` en entidades y DTOs.
- Se devuelve error 400 para datos inválidos y 404 cuando un recurso no se encuentra.

## Base de datos

La conexión se configura en `appsettings.json` bajo `DefaultConnection`. La base de datos se crea automáticamente si no existe.

### 📦 Clonar el repositorio

```bash
git clone https://github.com/Rocio-Medran/PruebaTecnicaApi.git
```

## Ejecutar la API

1. Clonar el repositorio
2. Configurar la cadena de conexión en `appsettings.json`
3. Ejecutar el proyecto
4. Acceder a Swagger en `https://localhost:<puerto>/swagger`

---

Desarrollado como parte de una prueba técnica de desarrollo backend .NET.
