using Exercise4;
using Swashbuckle.Application;
using System.Web.Http;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Exercise4
{
    /// <summary>
    /// Swagger Configurations takes place here.
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// Configurations are registered here.
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c =>
            {
                c.IncludeXmlComments(string.Format(@"{0}\bin\Exercise4.xml", System.AppDomain.CurrentDomain.BaseDirectory));
                c.SingleApiVersion("v1", "Exercise4");
            }).EnableSwaggerUi(c =>
            {

            });
        }
    }
}
