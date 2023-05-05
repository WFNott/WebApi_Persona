/// Te permite acceder al Metadata de las clases que se usan en la solución, obteniendo informacion sobre los ensamblados
/// y los tipos de datos que este contiene
/// 
///Un ensamblado es un archivo que contiene código, metadatos y recursos de .NET
///que se utiliza para la distribución, reutilización, versión y seguridad del código en .NET.
using System.Reflection;

namespace Exercise.Host.ModuleIntegration
{
    public class Module
    {
        public Module(string routePrefix, IStartup startup)
        {
            RoutePrefix = routePrefix;
            Startup = startup;
        }

        /// <summary>
        /// Crea un Prefijo de Ruta para los controladores, evitando confusiones y mejorando la organizacion
        /// se usa junto el [RoutePrefix = "api/name"]
        /// </summary>
        public string RoutePrefix { get; }

        /// <summary>
        /// Se usa para modificar la configuración Inicial del modulo
        /// configuración de servicios, la configuración de middleware, la configuración de enrutamiento, etc.,
        /// pertenece a la clase "WebHostBuilderContext" que pertenece a la Interfaz "IWebHostEnvironment"
        /// Se usa con "ConfigureWebHostDefaults" para modificar la configuración Inicial
        /// </summary>
        public IStartup Startup { get; }

        /// <summary>
        /// Assembly esta hecho para la transmision de los ensamblados pertenecientes al Startup
        /// Startup.GetType().Assembly = Trae el ensamblado segun el tipo en el Startup y se almacena en el Assembly 
        /// </summary>

        public Assembly Assembly => Startup.GetType().Assembly;

      

    }
}
