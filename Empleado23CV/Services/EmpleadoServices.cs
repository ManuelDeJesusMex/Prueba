using Empleado23CV.Context;
using Empleado23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado23CV.Services
{
    public class EmpleadoServices
    {

        public void Add(Empleados request)
        {
			try
			{				

				using (var _context = new ApplicationDbContext())
				{
                    Empleados empleado = new Empleados()
                    {
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        Correo = request.Correo,
                        FechaRegistro = DateTime.Now,
                    };

                    _context.Empleado.Add(empleado);
                    _context.SaveChanges();

                }

				
			}
			catch (Exception ex)
			{

				throw new Exception("Error: "+ex.Message);
			}
        }

        public Empleados Read(int ID)
        {

            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    Empleados empl = _context.Empleado.Find(ID);

                    return empl;

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);
            }

        }
    }
}
