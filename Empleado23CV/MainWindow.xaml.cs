using Empleado23CV.Entities;
using Empleado23CV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ubiety.Dns.Core.Records;

namespace Empleado23CV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Empleados empl = new Empleados();
            EmpleadoServices serv = new EmpleadoServices();
            
            empl.Nombre = txtNombre.Text;
            empl.Apellido = txtApellido.Text;
            empl.Correo = txtCorreo.Text;

            //Agregar una condicion para no enviar datos nulos

            if (empl.Correo != null && empl.Apellido != null && empl.Nombre != null)
            {
                serv.Add(empl);


                txtNombre.Clear();
                txtApellido.Clear();

                MessageBox.Show("Los datos se guardaron correctaron");
            } else if (empl.Correo == null || empl.Apellido == null || empl.Nombre == null)
            {
                Console.WriteLine("Hay campos vacíos");
            }

            
        }
    }
}
