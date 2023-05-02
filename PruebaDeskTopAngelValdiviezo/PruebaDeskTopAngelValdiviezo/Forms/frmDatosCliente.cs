using PruebaDeskTopAngelValdiviezo.Models;
using PruebaDeskTopAngelValdiviezo.Services;
using PruebaDeskTopAngelValdiviezo.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeskTopAngelValdiviezo.Forms
{
    public partial class frmDatosCliente : Form
    {
        byte[] arregloImg;
        public frmDatosCliente()
        {
            InitializeComponent();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                lblValidaCedula.Text = "Ingrese número";
                e.Handled = true;
                return;
            }
            lblValidaCedula.Text = "";
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                lblValidaCelular.Text = "Ingrese número";
                e.Handled = true;
                return;
            }
            lblValidaCelular.Text = "";
        }

        private void btnSubirFotoPerfil_Click(object sender, EventArgs e)
        {
            utils objUtils = new utils();
            OpenFileDialog abrirFotoPerfil = new OpenFileDialog();
            if(abrirFotoPerfil.ShowDialog() == DialogResult.OK)
            {
                byte[] arregloImg = File.ReadAllBytes(abrirFotoPerfil.FileName);

                //Valido el formato de la imagen
                bool formatoValido = objUtils.validateImage(arregloImg);
                if(formatoValido)
                {
                    arregloImg = File.ReadAllBytes(abrirFotoPerfil.FileName);
                    pctBoxFotoPerfil.ImageLocation = abrirFotoPerfil.FileName;
                    pctBoxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            utils objUtils = new utils();
            Cliente objCliente = new Cliente();
            objCliente.nombre = txtNombre.Text;
            objCliente.apellido = txtApellido.Text;
            objCliente.cedula = txtCedula.Text;
            objCliente.telefono = txtTelefono.Text;
            objCliente.cursos = txtCursos.Text;
            objCliente.fotoPerfil = arregloImg;
            objCliente.correo = txtCorreo.Text;
            bool correoValido = objUtils.VerificaCorreo(objCliente.correo);
            bool cedulaValida = objUtils.VerificaCedula(objCliente.cedula);

            if(objCliente.nombre.Trim() == "" || objCliente.apellido.Trim() == "" || 
                objCliente.cedula.Trim() == "" || objCliente.telefono.Trim() == "" || 
                objCliente.cursos.Trim() == "" || objCliente.fotoPerfil == null || 
                objCliente.correo.Trim() == "")
            {
                MessageBox.Show("Llene todos los datos solicitados por favor...");
                return;
            }

            if (!correoValido)
            {
                lblMensajeCorreo.Text = "Ingrese un correo válido...";
                return;
            }
            else
            {
                lblMensajeCorreo.Text = "";
            }

            if (!cedulaValida)
            {
                lblValidaCedula.Text = "Ingrese una cédula válida...";
                return;
            }
            else
            {
                lblValidaCedula.Text = "";
            }

            ClienteServices objClienteServices = new ClienteServices();

            String numError = "";
            String msmError = "";
            
            bool objGuardado = objClienteServices.IngresaCliente(objCliente, ref numError, ref msmError);

            String mensajeMostrar = "";

            if(!objGuardado)
            {
                mensajeMostrar = "No se pudo ingresar la data correctamente";
                
            }
            else
            {
                mensajeMostrar = "Cliente registrado correctamente";
            }

            MessageBox.Show(mensajeMostrar);
        }

    }
}
