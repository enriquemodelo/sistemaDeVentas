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

            //Mostrar todos los usuarios List<Rol> listaRol = new CN_Rol().Listar();
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvDataUsuarios.Rows.Add(new object[] {"", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1:0,
                    item.Estado == true ? "Activo" : "No Activo"
                });

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cmbRol.SelectedItem).Valor) },
                Documento = txtNumeroEmpleado.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Correo = txtCorreo.Text,
                Clave = txtPassword.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cmbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            //aqui valida si es usuario nuevo (agregar)
            if(objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvDataUsuarios.Rows.Add(new object[] {"", idusuariogenerado, txtNumeroEmpleado.Text, txtNombreCompleto.Text, txtCorreo.Text, txtPassword.Text,
                    ((OpcionCombo)cmbRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cmbRol.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString()
                    });

                    limpiar();

                    MessageBox.Show("El USUARIO se registro con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje);
                    //MetroFramework.MetroMessageBox.Show(this, mensaje);
                }
            }
            else
            {
                //metodo para actualizar
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvDataUsuarios.Rows[Convert.ToInt32(txtIndice.Text)];                    
                    row.Cells["IdUsuario"].Value = txtIdUsuario.Text;
                    row.Cells["Documento"].Value = txtNumeroEmpleado.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtPassword.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cmbRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cmbRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cmbEstado.SelectedItem).Texto.ToString();

                    limpiar();

                    MessageBox.Show("El USUARIO se actualizo con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje);
                    //MetroFramework.MetroMessageBox.Show(this, mensaje);
                }
            }

            

            


        }

        private void limpiar()
        {
            txtIndice.Text = "-1";
            txtIdUsuario.Text = "0";
            txtNumeroEmpleado.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtPassword.Text = "";
            txtConfirmarPassword.Text = "";
            cmbEstado.SelectedIndex = 0;

            txtNumeroEmpleado.Select();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgvDataUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            // Para pintar la imagen en una caja 
            if (e.RowIndex < 0)
                return;

            if(e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 4;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 4;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;

            }



        }

        private void dgvDataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDataUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionarUsuario")
            {
                int indice = e.RowIndex;

                if(indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtIdUsuario.Text = dgvDataUsuarios.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtNumeroEmpleado.Text = dgvDataUsuarios.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvDataUsuarios.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvDataUsuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtPassword.Text = dgvDataUsuarios.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfirmarPassword.Text = dgvDataUsuarios.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in cmbRol.Items)
                    {
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvDataUsuarios.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cmbRol.Items.IndexOf(oc);
                            cmbRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cmbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvDataUsuarios.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cmbEstado.Items.IndexOf(oc);
                            cmbEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtIdUsuario.Text) != 0)
            {
                //si es el usuario a eliminar es el id 1 ADMIN no se puede
                if (Convert.ToInt32(txtIdUsuario.Text) == 1)
                {
                    MessageBox.Show("No se puede eliminar este usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        string mensaje = string.Empty;

                        Usuario objusuario = new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
                        };

                        bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                        if (respuesta)
                        {


                            dgvDataUsuarios.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                            limpiar();

                            MessageBox.Show("El usuario se a eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    };
                }
                    

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cmbBusqueda.SelectedItem).Valor.ToString();

            if(dgvDataUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataUsuarios.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))                    
                        row.Visible = true;                    
                    else                    
                        row.Visible = false;                    
                }
                
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach(DataGridViewRow row in dgvDataUsuarios.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
