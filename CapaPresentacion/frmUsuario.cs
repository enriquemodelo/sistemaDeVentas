using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

            cmbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cmbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Valor";
            cmbEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach(Rol item in listaRol)
            {
                cmbRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });                
            }
            cmbRol.DisplayMember = "Texto";
            cmbRol.ValueMember = "Valor";
            cmbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvDataUsuarios.Columns)
            {
                if(columna.Visible == true && columna.Name != "btnSeleccionarUsuario")
                {
                    cmbBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cmbBusqueda.DisplayMember = "Texto";
            cmbBusqueda.ValueMember = "Valor";
            cmbBusqueda.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvDataUsuarios.Rows.Add(new object[] {"", txtIdUsuario.Text, txtNumeroEmpleado.Text, txtNombreCompleto.Text, txtCorreo.Text, txtPassword.Text,
                ((OpcionCombo)cmbRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cmbRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString()
            });

            limpiar();
        }

        private void limpiar()
        {
            txtIdUsuario.Text = "0";
            txtNumeroEmpleado.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtPassword.Text = "";
            txtConfirmarPassword.Text = "";
            cmbEstado.SelectedIndex = 0;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

    }
}
