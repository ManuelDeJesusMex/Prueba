using Empleado23CV.Context;
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

        //

        EmpleadoServices empleadoServices = new EmpleadoServices();
        Empleados empl = new Empleados();


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
                txtCorreo.Clear();

                MessageBox.Show("Los datos se guardaron correctaron");
            } else if (txtNombre.Text == "" || txtApellido.Text == "" || txtCorreo.Text == "")
            {
                Console.WriteLine("Hay campos vacíos");
            }


        }





        private void btn_watch_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);

            //Empleados empl = empleadoServices.


            Empleados empl = empleadoServices.Read(id);

            txtNombre.Text = empl.Nombre;
            txtApellido.Text = empl.Apellido;
            txtCorreo.Text = empl.Correo;
            txtFecha.Text = empl.FechaRegistro.ToString();

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

            int id = int.Parse(txtId.Text);

            empleadoServices.Delete(id);

            txtApellido.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            txtFecha.Clear();
            txtId.Clear();

            
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            //if (txtId.Text == "")
            //{
            //    MessageBox.Show("ID vacío");
            //} else
            //{
            //    int id = int.Parse(txtId.Text);
            //    if (txtNombre.Text == null && txtApellido.Text == null && txtCorreo.Text == null && txtId.Text == null & txtFecha.Text == null)
            //    {
            //        MessageBox.Show("No hay usuario");
            //    }
            //    else
            //    {
            //        empl.Nombre = txtNombre.Text;
            //        empl.Apellido = txtApellido.Text;
            //        empl.Correo = txtCorreo.Text;

            //        if (txtApellido.Text == "" && empl.Apellido == "" && txtCorreo.Text == "")
            //        {
            //            MessageBox.Show("Hay campos vacíos, por lo que se actualizarán de esa manera");
            //        }
            //        else
            //        {
            //            empleadoServices.Update(id, empl);
            //            txtApellido.Clear();
            //            txtCorreo.Clear();
            //            txtNombre.Clear();
            //            txtFecha.Clear();
            //            txtId.Clear();
            //        }

            //    }

            if (int.TryParse(txtId.Text, out int id))
            {
                Empleados empleadoactu = new Empleados()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Correo = txtCorreo.Text,
                    FechaRegistro = DateTime.Now
                };

                empleadoServices.Update(id, empleadoactu);

                txtApellido.Clear();
                txtCorreo.Clear();
                txtNombre.Clear();
                txtFecha.Clear();
                txtId.Clear();
            } 


        }

            
        
    }
}
