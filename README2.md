# PazYSalvoAPP
## -- Configuración de Proyecto
--- Utilización de SQLite en C# .Net con Entity Framework en modo Code First
## -- Instalación de Librerías
--- Entity Framework:
---- Microsoft.EntityFrameworkCore
---- Microsoft.EntityFrameworkCore.Sqlite
## -- Proceso de Instalación
--- Acceso a "Administrar Paquetes Nuget" en el proyecto
--- Búsqueda y selección de las librerías deseadas
--- Instalación de las versiones correspondientes para evitar conflictos
## -- Creación de Clases
--- Definición de clases para representar las entidades de la base de datos
## -- Ejemplo:
--- Clase "Estado"
---- Propiedades: Id, Nombre, Descripción
--- Clase "Roles"
---- Propiedades: Id, Nombre, Descripción,ACTIVO
--- Clase "CLientes"
---- Propiedades: Id, Personaid, Rolid
--- Clase "Facturas"
---- Propiedades: id,saldo, clienteid, servicioAdquirido,medio de pago
--- Clase "Pago"
---- Propiedades: Id, MontoDePago, FacturaId
## -- Creación de Contexto
--- Contexto de la base de datos para operaciones como recuperar, insertar, actualizar o eliminar objetos
--- Administración de transacciones, seguimiento de cambios, control de concurrencia y gestión de la caché
--- Organización en carpeta separada llamada "context"
## -- Nota Importante
--- Ajustar valores de acuerdo a las entidades o tablas mencionadas
--- Considerar el orden de creación de entidades con llaves foráneas, asegurando que las relaciones estén definidas correctamente.

# JOHN ALEJANDRO MIRANDA MELGUIZO