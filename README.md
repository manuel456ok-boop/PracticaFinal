# PracticaFinal

 📋 Sistema de Gestión de Solicitudes de Servicio

Este proyecto es una aplicación de consola desarrollada en **C#** que permite gestionar solicitudes de servicio técnico mediante el uso de **enumeradores (`enum`)** para estandarizar los estados, mejorando la claridad y evitando errores comunes como textos libres o mal escritos.

## 🎯 Objetivo del Proyecto

Aplicar el uso de enum en un sistema real para representar valores constantes y controlar el flujo de estados de las solicitudes, aplicando principios de **Programación Orientada a Objetos (POO)**.

## 🧠 Uso del Enumerador (`enum`)

El enumerador EstadoSolicitud se definió de la siguiente manera:
`csharp
enum EstadoSolicitud
{
    Pendiente,
    EnProceso,
    Completada,
    Cancelada
}


Ventajas de usar enum en este proyecto:
Estandarización: Los estados siempre se escriben de la misma forma.

Validación automática: No se pueden asignar valores diferentes a los definidos.

Legibilidad: El código es más claro y fácil de mantener.

Control de flujo: Se puede usar en switch o condiciones de forma segura.

Este enum se utiliza en la clase Solicitud como tipo de la propiedad Estado, y se asigna desde el menú mediante una conversión directa ((EstadoSolicitud)opcion).

Funcionalidades
El sistema permite:

Registrar una nueva solicitud (se asigna automáticamente como Pendiente).

 Mostrar todas las solicitudes registradas.

Buscar una solicitud por su ID.

Cambiar el estado de una solicitud (solo usando los valores del enum).

Salir del programa.

Requerimientos Técnicos Implementados
Uso correcto de enum

Clases (Solicitud, GestorSolicitudes) con propiedades y métodos

Estructuras de control (if, switch)

Interacción por consola con menú dinámico

imagenes del funcionamiento del programa:

<img width="1772" height="855" alt="image" src="https://github.com/user-attachments/assets/3c57df3f-fdec-469e-a231-1becbb8919da" />

<img width="1658" height="841" alt="image" src="https://github.com/user-attachments/assets/b331f86d-6901-4dda-af9c-b7525f8323f5" />

<img width="1667" height="853" alt="image" src="https://github.com/user-attachments/assets/07bdd789-0a1e-4c5c-b3ac-920118a82bbb" />

<img width="1718" height="918" alt="image" src="https://github.com/user-attachments/assets/5db8682f-47f5-4667-bffb-26e5673e6639" />

<img width="1682" height="834" alt="image" src="https://github.com/user-attachments/assets/400137e7-0a90-4239-878d-af3b0d4b4641" />

<img width="1796" height="834" alt="image" src="https://github.com/user-attachments/assets/6b27f6bc-c022-43d0-aaba-c905224f6f4b" />







Uso de List<T> para almacenar solicitudes

Validación de entrada de datos (IDs, opciones)

