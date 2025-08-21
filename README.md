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


## 👨‍💻 Notas del desarrollo

- Este proyecto es mi primera experiencia en Blazor.
- 🔧 **Datos Hardcodeados**: Tanto los usuarios como los videojuegos están cargados de manera manual en los services (`UsuarioService` y `VideojuegoService`).  
  👉 Esto fue hecho de manera intencional como parte de mi primer experiencia con Blazor, para enfocarme en el funcionamiento y no en la persistencia de datos.
- En un futuro se podría mejorar con una API real + base de datos para manejar la persistencia.
- Este proyecto es mi primera experiencia en Blazor.
- Manejo básico de imágenes desde wwwroot.


## 📸 Capturas de Pantalla

<img width="1405" height="702" alt="image" src="https://github.com/user-attachments/assets/b379480a-68cd-448f-bc7a-00078533dacc" />
<img width="1400" height="708" alt="image" src="https://github.com/user-attachments/assets/ab1d9fff-aa08-4667-8039-0f20dd57dc10" />
<img width="1394" height="693" alt="image" src="https://github.com/user-attachments/assets/feac264b-27db-4053-81ac-5edb0c8cf08a" />
<img width="1412" height="690" alt="image" src="https://github.com/user-attachments/assets/495be269-a25b-486b-8a76-11dd8b46f0b0" />


🚀 Uso

- Iniciar la aplicación.
- Loguearse con un usuario válido (cargado en memoria con UsuarioService).
- Acceder al menú principal.
- Gestionar Usuarios y Videojuegos (altas, bajas, modificaciones, consultas).

## 🚀 Cómo Ejecutar el Proyecto

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/Leo-Renzi/VideojuegosApp.git
   
2. Abrir el proyecto con Visual Studio 2022.
3. Ejecutar en un emulador o dispositivo real con soporte .NET MAUI.


👨‍💻 Autor

Leonardo Renzi
