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
                    
      
                          **{
                    


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
                    }** 
                    
                    
---en nuestro main, abriremos nuestra cadena de conexion
            """"""""""""
                    
                        builder.Services.AddDbContext<PazSalvoContext>( c =>
                    {
                        c.UseSqlServer(builder.Configuration.GetConnectionString("connString"));
                    });  
                
            """"""""""""
## -- Proceso de Instalación
--- Acceso a "Administrar Paquetes Nuget" en el proyecto
--- Búsqueda y selección de las librerías deseadas
--- Instalación de las versiones correspondientes para evitar conflictos
## -- Creación de Clases
--- Definición de clases para representar las entidades de la base de datos
---Definicion de controladores , modelos, scripts, vistas e interfaces
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

        """"""""""""""
                    using System;
                    using System.Collections.Generic;
                    using System.Linq;
                    using System.Text;
                    using System.Threading.Tasks;

                    namespace PazYSalvoAPP.Data.Repositories
                    {
                        public interface IGenericRepository<T> where T : class
                        {
                            // Método CRUD
                            Task<bool> Insertar(T model);
                            Task<bool> Actualizar(T model);
                            Task<T> Leer(int id); // ?
                            Task<IQueryable<T>> LeerTodos(); // ?
                            Task<bool> Eliminar(int id);
                        }
                    }


        """"""""""""""
--- Administración de transacciones, seguimiento de cambios, control de concurrencia y gestión de la caché
--- Organización en carpeta separada llamada "context"

        """"""""""""""""""
                using Microsoft.EntityFrameworkCore;
                using PazYSalvoAPP.Models;
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Text;
                using System.Threading.Tasks;

                namespace PazYSalvoAPP.Data.Repositories
                {
                    // Definición de la clase FacturaRepository que implementa la interfaz IGenericRepository<Factura>
                    public class FacturaRepository : IGenericRepository<Factura>
                // 1- Establecer conexión
                        // Declaración de un campo privado readonly llamado _context de tipo PazSalvoContext
                        private readonly PazSalvoContext _context;

                        // Constructor de la clase que recibe una instancia de PazSalvoContext
                        public FacturaRepository(PazSalvoContext context)
                        {
                            _context = context; // Asignación de la instancia de PazSalvoContext al campo _context
                        }

        """"""""""""""""""

## -- Nota Importante
--- Ajustar valores de acuerdo a las entidades o tablas mencionadas
--- Considerar el orden de creación de entidades con llaves foráneas, asegurando que las relaciones estén definidas correctamente.
---tener en cuenta la lectura de los errtores, ingresar e instalar las instalaciones correctas
# JOHN ALEJANDRO MIRANDA MELGUIZO