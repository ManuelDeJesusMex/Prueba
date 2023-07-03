using Empleado23CV.Context;
using Empleado23CV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public void Delete (int ID)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {

                    Empleados emplD = _context.Empleado.Find(ID);

                    if (emplD != null)
                    {
                        _context.Empleado.Remove(emplD);
                        _context.SaveChanges();

                        MessageBox.Show("Eliminado");


                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario");
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: "+ex.Message);
            }
        }

        public void Update (int ID, Empleados empleados)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Empleados emplActu = _context.Empleado.Find(ID);

                    if (emplActu != null)
                    {
                        emplActu.Nombre = empleados.Nombre;
                        emplActu.Apellido = empleados.Apellido;
                        emplActu.Correo = empleados.Correo;
                        
                        _context.Update(emplActu);
                        _context.SaveChanges();

                        MessageBox.Show("Datos actualizados");

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception ("Error: "+ex.Message);
            }
        }

    }
}
