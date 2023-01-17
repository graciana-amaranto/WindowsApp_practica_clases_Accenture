using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();

            producto1.Nombre = "Cuadro";
            producto1.Descripcion = "Cuadro de mona lisa";
            producto1.PrecioCosto = 1500;
            producto1.Margen = 500;
            producto1.IVA = 0.10M;
            producto1.Categoria = "Arte";

            MessageBox.Show(producto1.Nombre + " " + producto1.Descripcion + " " + producto1.PrecioCosto + " " +
            producto1.Margen + " " + producto1.IVA + " " + producto1.PrecioBruto + " " + producto1.PrecioVenta + " " + producto1.Categoria );
        }

        private void btnClienteIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo cliente = new ClienteIndividuo();

            cliente.Nombre = "Marcos";
            cliente.Apellido = "Amaranto";
            cliente.CUIT = "458226";
            cliente.Email = "marcos@gmail.com";
            cliente.Telefono = "268421";
            cliente.Direccion = "Balcarce 987";

            MessageBox.Show(cliente.Nombre + " " + cliente.Apellido + " " + cliente.CUIT + " "
                + cliente.Email + " " + cliente.Telefono + " " + cliente.Direccion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
