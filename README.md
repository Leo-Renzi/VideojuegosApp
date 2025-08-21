# 🎮 VideojuegosApp

Proyecto desarrollado con **.NET MAUI Blazor Hybrid** como práctica de ABM (Alta, Baja, Modificación y Listado) de entidades, con el objetivo de aprender y familiarizarse con la tecnología.

## 📌 Funcionalidades

- **Login simple** de usuario (validación hardcodeada en memoria).
- **Detalle de Usuarios**:
  - Alta, baja, modificación y listado de usuarios.
  - Uso de imágenes locales cargadas desde *wwwroot*.
- **Detalle de Videojuegos**:
  - Alta, baja, modificación y listado de videojuegos.
  - También con imágenes locales desde *wwwroot*.
- Navegación entre páginas utilizando **Blazor Components**.
- Uso de **Services** para gestionar la lógica de negocio.

## 🗂️ Estructura del Proyecto

VideojuegosApp/
│── wwwroot/ # Archivos estáticos (imágenes usadas en Usuarios y Videojuegos)
│── Components/ # Componentes reutilizables de Blazor
│── Models/ # Modelos de datos (Usuario, Videojuego)
│── Services/ # Servicios (UsuarioService, VideojuegoService)
│── App.xaml # Configuración principal de la app
│── MainPage.xaml # Página raíz
│── MauiProgram.cs # Configuración de servicios y dependencias


## ⚙️ Tecnologías Utilizadas

- [.NET MAUI](https://learn.microsoft.com/dotnet/maui)
- [Blazor Hybrid](https://learn.microsoft.com/aspnet/core/blazor/hybrid)
- C#
- Razor Components
- Bootstrap 5 (para el diseño visual)

## 🚧 Notas Importantes

- 🔧 **Datos Hardcodeados**: Tanto los usuarios como los videojuegos están cargados de manera manual en los services (`UsuarioService` y `VideojuegoService`).  
  👉 Esto fue hecho de manera intencional como parte de mi primer experiencia con Blazor, para enfocarme en el funcionamiento y no en la persistencia de datos.
- Se podrían reemplazar fácilmente por una base de datos real o una API REST en el futuro.

## 📸 Capturas de Pantalla

_(Agregar aquí capturas de tu aplicación mostrando el Login, Usuarios y Videojuegos)_

## 🚀 Cómo Ejecutar el Proyecto

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/Leo-Renzi/VideojuegosApp.git
