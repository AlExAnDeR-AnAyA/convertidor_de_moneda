## **Convertidor de Moneda**
Este proyecto es un convertidor de moneda que convierte pesos colombianos a dólares y euros.

## Requisitos
.NET SDK instalado
Visual Studio Code

## Instrucciones para Ejecutar
Clona este repositorio.
Abre el proyecto en Visual Studio Code.
Compila y ejecuta el archivo Program.cs.

## Funcionalidades
Conversión de pesos colombianos a dólares y euros.
Validación de la entrada del usuario.

1. ## Adaptabilidad
-**Pregunta:**
Imagina que en tu equipo tienes que cambiar de tecnología en mitad de un proyecto. ¿Qué pasos seguirías para adaptarte rápidamente y entender la nueva tecnología?

-**Respuesta:**
Investigar sobre la nueva tecnología, comenzando por la documentación oficial.
Buscar tutoriales y cursos cortos que me ayuden a entender su funcionalidad y cómo se aplica a proyectos reales.
Consultar con compañeros de equipo o superiores que tengan experiencia en la tecnología y pedir retroalimentación sobre cómo integrarla eficazmente.
Practicar con ejercicios que me permitan afianzar lo aprendido y conocer el alcance de la nueva tecnología.

2. ## Capacidad de Resolución de Problemas
-**Pregunta:**
¿Cómo abordarías un problema en el que tu código funciona en tu máquina local, pero falla en un servidor de producción?

-**Respuesta:**
Lo primero sería revisar los errores que se están generando y analizar los mensajes para determinar la causa del fallo. Después, verificaría que la configuración del entorno de producción sea similar a la de mi entorno local, incluyendo las versiones de software y otros factores que puedan influir en el funcionamiento correcto del sistema.

3. ## Conocimientos en Desarrollo (.NET)
-**Pregunta:**
Describe brevemente en qué casos preferirías usar .NET sobre Java y viceversa.

-**Respuesta:**
**.NET:** Preferiría usar .NET en entornos Windows, ya que está optimizado para esta plataforma. También lo elegiría para desarrollo web debido a su integración con herramientas como ASP.NET Core y su facilidad para crear aplicaciones escalables.
**Java:** Optaría por Java si el proyecto requiere multiplataforma desde el inicio o si es necesario asegurar compatibilidad con sistemas operativos como Linux o macOS, ya que Java está diseñado para ser independiente de la plataforma.

4. ## Estructura de una Aplicación Cliente-Servidor en .NET
-**Pregunta:**
Defina la estructura de una aplicación cliente-servidor en tecnología Microsoft .NET y justifique la selección. La aplicación registrará los datos básicos de una persona en la plataforma a través de un formulario que debe permitir adjuntar archivos. Indique cómo estructuraría el aplicativo del lado del servidor (API).

-**Respuesta:**
Estructuraría el proyecto utilizando una arquitectura en capas, de la siguiente manera:

Proyecto.DAL (Capa de Acceso a Datos):

Se encarga de las conexiones a la base de datos, consultas SQL, y procedimientos almacenados.
Proyecto.Model (Modelos de Datos):

Contiene las clases que representan las entidades del sistema, como Persona y ArchivoAdjunto.
Proyecto.Interfaces:

Define las interfaces que deben implementar las clases de la capa de negocio para garantizar la separación de responsabilidades y la flexibilidad del sistema.
Proyecto.Business (Lógica de Negocio):

Procesa la lógica de la aplicación, como validar datos, gestionar el almacenamiento de archivos y realizar cálculos si es necesario.
Proyecto.API (Capa de API):

Proporciona los endpoints para interactuar con el cliente a través de HTTP (REST API). Maneja las solicitudes para registrar los datos de la persona y los archivos adjuntos.
## Justificación:
**Esta estructura es beneficiosa porque:**

Facilita el mantenimiento y la escalabilidad del sistema, ya que cada capa tiene responsabilidades claras y definidas.
Mejora la reutilización de código mediante la separación de preocupaciones, permitiendo que las capas de acceso a datos y lógica de negocio sean fácilmente reutilizadas en diferentes contextos.
Optimiza el rendimiento al segmentar el sistema en partes específicas, lo que permite optimizar cada una según sus necesidades.
