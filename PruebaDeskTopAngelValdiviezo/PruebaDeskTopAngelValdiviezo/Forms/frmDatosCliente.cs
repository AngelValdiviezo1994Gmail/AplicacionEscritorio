using PruebaDeskTopAngelValdiviezo.Models;
using PruebaDeskTopAngelValdiviezo.Services;
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

        public bool VerificaCedula(string numeroCedula)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;

            if(int.TryParse(numeroCedula, out isNumeric) && numeroCedula.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(numeroCedula[0], numeroCedula[1], string.Empty));
                var digitoTres = Convert.ToInt32(numeroCedula[2] + string.Empty);

                if((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito )
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(numeroCedula[9] + string.Empty);
                    for(var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) * Convert.ToInt32(numeroCedula[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }

                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;

                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }
    
        public bool VerificaCorreo(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
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
            OpenFileDialog abrirFotoPerfil = new OpenFileDialog();
            if(abrirFotoPerfil.ShowDialog() == DialogResult.OK)
            {
                byte[] arregloImg = File.ReadAllBytes(abrirFotoPerfil.FileName);

                //Valido el formato de la imagen
                bool formatoValido = validateImage(arregloImg);
                if(formatoValido)
                {
                    arregloImg = File.ReadAllBytes(abrirFotoPerfil.FileName);
                    pctBoxFotoPerfil.ImageLocation = abrirFotoPerfil.FileName;
                    pctBoxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        public bool validateImage(byte[] bytes)
        {
            try
            {
                Stream stream = new MemoryStream(bytes);
                using (Image img = Image.FromStream(stream))
                {
                    if (img.RawFormat.Equals(ImageFormat.Jpeg) || img.RawFormat.Equals(ImageFormat.Png))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.nombre = txtNombre.Text;
            objCliente.apellido = txtApellido.Text;
            objCliente.cedula = txtCedula.Text;
            objCliente.telefono = txtTelefono.Text;
            objCliente.cursos = txtCursos.Text;
            objCliente.fotoPerfil = arregloImg;
            objCliente.correo = txtCorreo.Text;
            bool correoValido = VerificaCorreo(objCliente.correo);
            bool cedulaValida = VerificaCedula(objCliente.cedula);

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
