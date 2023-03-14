using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.DAL.DBContext;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.DAL.Implementacion;
using SistemaVenta.BLL.Interfaces;
using SistemaVenta.BLL.Implementacion;



namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            /// conexion a la base de datos 
            services.AddDbContext<DbventaContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });

            // inyeccion de dependicias de genericrepository 
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // inyeccion de dependia de la interface Iventarepository a la casa ventarepository
            services.AddScoped<IventaRepository, VentaRepository>();


            /// inyeccion de dependencia de envio de correo
            services.AddScoped<ICorreoService, CorreoService>();


        }
    }
}
