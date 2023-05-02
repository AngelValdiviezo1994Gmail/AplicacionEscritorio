using PruebaDeskTopAngelValdiviezo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using PruebaDeskTopAngelValdiviezo.AccesoDatos;

namespace PruebaDeskTopAngelValdiviezo.Services
{
    public class ClienteServices
    {
        public bool IngresaCliente(Cliente objClienteEntrada, ref string numError, ref string msgError)
        {
            int resp = 0;
            bool respuesta = true;
            ClsAccesoDatos accesoDato = new ClsAccesoDatos();
            XmlDocument xmlParametro = new XmlDocument();
            try
            {
                using (SqlCommand command = clsConexion.CrearConexion())
                {
                    accesoDato.ProcedimientoAlmacenado = "[dbo].[agregar_cliente_nextTi]";
                    xmlParametro.LoadXml("<Peticion />");
                    xmlParametro.DocumentElement.SetAttribute("nombreCliente", objClienteEntrada.nombre);
                    xmlParametro.DocumentElement.SetAttribute("apellidoCliente", objClienteEntrada.apellido);
                    xmlParametro.DocumentElement.SetAttribute("correoCliente", objClienteEntrada.correo);
                    xmlParametro.DocumentElement.SetAttribute("cedulaCliente", objClienteEntrada.cedula);
                    xmlParametro.DocumentElement.SetAttribute("cursosCliente", objClienteEntrada.cursos);
                    xmlParametro.DocumentElement.SetAttribute("fotoPerfilCliente", Convert.ToBase64String(objClienteEntrada.fotoPerfil));
                    xmlParametro.DocumentElement.SetAttribute("telefonoCliente", objClienteEntrada.telefono);
                    accesoDato.AgregarParametro("@PI_ParamXML", SqlDbType.Xml, xmlParametro.OuterXml);
                    accesoDato.AgregarParametroDeSalida("@MsgError", SqlDbType.VarChar, 500);
                    accesoDato.AgregarParametroDeSalida("@NumError", SqlDbType.Int, 4);
                    var resultado = accesoDato.Ejecutar();
                    msgError = accesoDato.LeerParametroDeSalida("@MsgError").Trim();
                    numError = accesoDato.LeerParametroDeSalida("@NumError").Trim();
                    resp = resultado;
                    respuesta = resp == 1 ? true : false;
                }
            } catch(Exception ex)
            {
                respuesta = false;
            }
            return respuesta;
        }
    }
}
