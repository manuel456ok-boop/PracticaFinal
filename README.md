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

Uso de List<T> para almacenar solicitudes

Validación de entrada de datos (IDs, opciones)

