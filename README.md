# 🏥 Sistema Gestor de Pacientes

**Aplicación web para gestionar pacientes, médicos, consultorios y citas médicas, desarrollada con ASP.NET Core MVC (.NET 9) y arquitectura Onion.**

---

## 🏗️ **Características Principales**
### 1️⃣ **Gestión de Pacientes**
   - Registro de pacientes (con foto), edición y eliminación.
   - Cédula, contacto, fecha de nacimiento, si es fumador y si tiene alergias.

### 2️⃣ **Manejo de Citas Médicas**
   - Creación, edición y eliminación de citas entre paciente y médico.
   - Fecha, hora, estado y motivo de cada cita.

### 3️⃣ **Médicos y Consultorios**
   - Registro de médicos con especialidad y consultorio (solo administradores).
   - Gestión de consultorios.

### 4️⃣ **Autenticación y Roles**
   - Registro e inicio de sesión con **ASP.NET Core Identity**.
   - Roles Admin y Usuario.

---

## 🌍 **Tecnologías Utilizadas**
- **Backend:** ASP.NET Core MVC (.NET 9)
- **Base de Datos:** SQL Server
- **ORM:** Entity Framework Core
- **Autenticación:** ASP.NET Core Identity
- **Validaciones:** Data Annotations
- **Arquitectura:** Onion (Domain, Application, Infrastructure.Persistence y la app web)

---

## 📌 **Requisitos Previos**
- 🟢 **.NET SDK 9.0**
- 🟢 **SQL Server**
- 🟢 **Visual Studio 2022** o **Visual Studio Code** con extensiones de C#

---

## ⚙️ **Configuración**

### 1️⃣ Crear la base de datos
Crea una base de datos vacía llamada `SistemaGestorPacientesDB` y ejecuta el script `GestorPacientesApp/wwwroot/db/SistemaGestorPacientesDB.sql`.

### 2️⃣ Configurar la conexión en **appsettings.json**:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=SistemaGestorPacientesDB;User Id=tuusuario;Password=tupassword;"
}
```

### 3️⃣ Iniciar sesión como administrador
Al arrancar, la app crea los roles y un usuario administrador de prueba:
- **Correo:** admin@sistema.com
- **Contraseña:** Admin123!

---

## 🤝 **Contribución**
Si deseas contribuir, sigue estos pasos:
1️⃣ Realiza un fork del proyecto
2️⃣ Realiza tus cambios y confirma (`git commit -m 'Añadir nueva funcionalidad'`)
3️⃣ Abre un Pull Request
