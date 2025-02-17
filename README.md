# 🏥 Sistema Gestor de Pacientes

**Un sistema avanzado para la gestión eficiente de pacientes, citas médicas y administración hospitalaria, desarrollado con ASP.NET Core MVC y la arquitectura Onion Architecture.**

---

## 🌟 **Nuestra Misión**
Facilitar la administración de hospitales y clínicas a través de un software robusto, seguro y escalable, optimizando la gestión de pacientes y mejorando la atención médica.

---

## 🏗️ **Características Principales**
### 1️⃣ **Gestión de Pacientes**
   - Registro, edición, eliminación y búsqueda de pacientes.
   - Historial clínico detallado.

### 2️⃣ **Manejo de Citas Médicas**
   - Programación, cancelación y reprogramación de citas.
   - Notificaciones automatizadas.

### 3️⃣ **Administración de Médicos y Especialidades**
   - Registro y gestión de médicos.
   - Asignación de especialidades y horarios de consulta.

### 4️⃣ **Autenticación y Seguridad**
   - Integración con **Identity** para autenticación y autorización.
   - Control de accesos basado en roles.

---

## 🌍 **Tecnologías Utilizadas**
- **Backend:** ASP.NET Core MVC, Entity Framework Core
- **Base de Datos:** SQL Server
- **ORM:** Entity Framework Core
- **Validaciones:** Fluent Validation
- **Automatización:** AutoMapper
- **Arquitectura:** Onion Architecture

---

## 📌 **Requisitos Previos**
- 🟢 **.NET SDK 8.0+**
- 🟢 **SQL Server**
- 🟢 **Visual Studio 2022** o **Visual Studio** con extensiones de C#

---

## ⚙️ **Instalación y Configuración**
### 1️⃣ Clonar el repositorio:
```sh
   git clone https://github.com/tuusuario/SistemaGestorPacientes.git
   cd SistemaGestorPacientes
```
### 2️⃣ Configurar la base de datos en **appsettings.json**:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=SistemaGestorPacientes;User Id=tuusuario;Password=tupassword;"
}
```
### 3️⃣ Aplicar las migraciones y actualizar la base de datos:
```sh
   dotnet ef database update
```
### 4️⃣ Ejecutar el proyecto:
```sh
   dotnet run
```

---

## 🤝 **Contribución**
Si deseas contribuir, sigue estos pasos:
1️⃣ Realiza un fork del proyecto
2️⃣ Crea una nueva rama (`git checkout -b feature-nueva-funcionalidad`)
3️⃣ Realiza tus cambios y confirma (`git commit -m 'Añadir nueva funcionalidad'`)
4️⃣ Sube los cambios (`git push origin feature-nueva-funcionalidad`)
5️⃣ Abre un Pull Request

