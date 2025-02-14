🏥 Sistema Gestor de Pacientes

Sistema de gestión de pacientes desarrollado con ASP.NET Core MVC utilizando la arquitectura Onion Architecture.

🚀 Tecnologías utilizadas

🔹 ASP.NET Core MVC - Framework principal

🔹 Entity Framework Core - ORM para la gestión de base de datos

🔹 SQL Server - Base de datos

🔹 AutoMapper - Mapeo de objetos

🔹 Fluent Validation - Validación de datos

🔹 Onion Architecture - Arquitectura de diseño

🏗️ Arquitectura

El proyecto sigue el patrón Onion Architecture, que separa las responsabilidades en capas bien definidas:

📌 Core (Dominio): Contiene las entidades de negocio y las interfaces.
📌 Application: Implementa la lógica de negocio y casos de uso.
📌 Infrastructure: Contiene la implementación de repositorios y acceso a datos.
📌 Presentation (UI - ASP.NET Core MVC): Interfaz de usuario y controladores.

✨ Características del sistema

✅ Gestión de pacientes (registro, edición, eliminación, búsqueda)
✅ Manejo de citas médicas
✅ Administración de médicos y especialidades
✅ Control de historial clínico
✅ Autenticación y autorización con Identity

📌 Requisitos previos

🟢 .NET SDK 7.0+

🟢 SQL Server

🟢 Visual Studio 2022 o VS Code con extensiones de C#

⚙️ Instalación y configuración

1️⃣ Clonar el repositorio:

   git clone https://github.com/tuusuario/SistemaGestorPacientes.git
   cd SistemaGestorPacientes

2️⃣ Configurar la base de datos en appsettings.json:

"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=SistemaGestorPacientes;User Id=tuusuario;Password=tupassword;"
}

3️⃣ Aplicar las migraciones y actualizar la base de datos:

   dotnet ef database update

4️⃣ Ejecutar el proyecto:

   dotnet run

🤝 Contribución

Si deseas contribuir, sigue estos pasos:
1️⃣ Realiza un fork del proyecto
2️⃣ Crea una nueva rama (git checkout -b feature-nueva-funcionalidad)
3️⃣ Realiza tus cambios y confirma (git commit -m 'Añadir nueva funcionalidad')
4️⃣ Sube los cambios (git push origin feature-nueva-funcionalidad)
5️⃣ Abre un Pull Request
