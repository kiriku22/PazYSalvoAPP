# PazYSalvoAPP
## -- Configuración de Proyecto
--- Utilización de SQLite en C# .Net con Entity Framework en modo Code First
## -- Instalación de Librerías
--- Entity Framework:
---- Microsoft.EntityFrameworkCore
---- Microsoft.EntityFrameworkCore.Sqlite
## --Instalacion y conexion (Database first)
    ---En la terminal de los paquetes NuGets usaremos el siqguiente comando para establecer la conexion con SQL server , especificamos el servidor y la data base como se nos indica :
    **Scaffold-DbContext "Data Source=NOMBRE_SERVIDOR;Initial Catalog=PazSalvo;Integrated Security=true;Encrypt=True;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore. SqlServer -OutPutDir Context**
    ---luego en el archivo appsettings.js haremos esta conexion
                    
                    """" 
                          {
                    


                    "Logging": {
                        "LogLevel": {
                        "Default": "Information",
                        "Microsoft.AspNetCore": "Warning"
                        }
                    },
                    "ConnectionStrings": {
                        "connString": "Data Source=NOMBRE_SERVIDOR;Initial Catalog=PazSalvo;Integrated Security=true;Encrypt=True;TrustServerCertificate=true;"
                    },
                    "AllowedHosts": "*"
                    } 
                    
                    
                    """"

    ---en nuestro main, abriremos nuestra cadena de conexion
            """"""
            
                    builder.Services.AddDbContext<PazSalvoContext>( c =>
            {
                c.UseSqlServer(builder.Configuration.GetConnectionString("connString"));
            });  
            
            """"""
## -- Proceso de Instalación
--- Acceso a "Administrar Paquetes Nuget" en el proyecto
--- Búsqueda y selección de las librerías deseadas
--- Instalación de las versiones correspondientes para evitar conflictos
## -- Creación de Clases
--- Definición de clases para representar las entidades de la base de datos
---Definicion de controladores , modelos scripts y vistas
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
---tener en cuenta la lectura de los errtores, ingresar e instalar las instalaciones correctas
# JOHN ALEJANDRO MIRANDA MELGUIZO