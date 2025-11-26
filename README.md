# SistemaVentasZPT

Proyecto desarrollado como parte del curso de Desarrollo de Software. Es un sistema integral para la gestión de ventas, facturación, compras, clientes, productos y reportes en un entorno comercial.

## Descripción general

El sistema permite administrar operaciones de ventas y compras, gestionar clientes, controlar inventario de productos y generar reportes como facturas, boletas, kardex y nómina de empleados. Utiliza procedimientos almacenados en SQL para la gestión de la base de datos y está construido con múltiples capas (presentación, lógica y datos) siguiendo buenas prácticas de arquitectura en C#.

## Funcionalidades principales

- **Gestión de productos**: Altas, bajas, modificación y control de stock.
- **Gestión de ventas**: Registro de ventas, facturación, generación de boletas y facturas electrónicas.
- **Gestión de compras**: Registro de compras, administración de proveedores.
- **Gestión de clientes**: Registro y administración de clientes.
- **Reportes**: Diferentes reportes de operaciones (Kardex, facturación, empleados).
- **Generación automática de códigos y números de comprobante**.
- **Interfaz visual**: Formularios para el registro y administración de entidades.
- **Exportación e impresión de comprobantes**.

## Dependencias y tecnologías utilizadas

- **Lenguaje principal:** C# (.NET Framework)
- **Base de datos:** SQL Server (procedimientos almacenados y scripts incluidos en `/SQLscripts`)
- **Estructura de capas:** 
  - `CapaPresentacion`: Formularios y recursos visuales (HTML, imágenes).
  - `CapaLogica`: Lógica de negocio y reglas de operación.
  - `CapaDatos`: Acceso y manipulación de datos.

## Instalación y uso

1. Clona el repositorio:
   ```bash
   git clone https://github.com/jepcec/SistemaVentasZPT.git
   ```
2. Configura la base de datos con los scripts en **/SQLscripts**.
3. Abre la solución en Visual Studio y configura la conexión a tu SQL Server.
4. Ejecuta el proyecto desde `CapaPresentacion` para acceder a la interfaz visual.

## Estructura del proyecto

- `/CapaPresentacion`: Interfaz de usuario y reportes.
- `/CapaLogica`: Clases para ventas, compras, productos y clientes.
- `/CapaDatos`: Acceso y gestión de la base de datos (procedimientos e interfaces).
- `/SQLscripts`: Scripts SQL para crear y poblar la base de datos.

## Uso de reportes y comprobantes

Los reportes como la factura, boleta, kardex y empleados pueden exportarse o imprimirse desde el sistema. Utilizan plantillas HTML presentes en el directorio `CapaPresentacion/Recursos`.

## Licencia

Este proyecto se distribuye con fines educativos. Consulta al autor para otros usos.

## Contacto y soporte

Para dudas, sugerencias o mejoras, utiliza la sección de [issues](https://github.com/jepcec/SistemaVentasZPT/issues) del repositorio.
