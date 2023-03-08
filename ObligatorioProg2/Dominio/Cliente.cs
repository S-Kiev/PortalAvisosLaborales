using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioProg2.Dominio
{
    public class Cliente
    {

        public Cliente (int codigo, DateTime fechaAlta, string nombre, int tipoDoc, int documento, string direccion, int telefono, int cantPub)
          {
            Codigo = codigo;
            FechaAlta = fechaAlta;
            Nombre = nombre;
            TipoDoc = tipoDoc;
            Documento = documento;
            Direccion = direccion;
            Telefono = telefono;
            CantidadPub = cantPub;
            }

        public Cliente()
        {

        }
        public int Codigo { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Nombre { get; set; }
        public int TipoDoc { get; set; }
        public int Documento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int CantidadPub { get; set; }

    }


    /*
      
     public string ListarCliente (int codigo // o en su defecto un objeto Cliente) {
    string tabla = "<table //(clases de Bootstrap)//><tr><th>NOMBRE</th><th> APELLIDO </th><th>CEDULA</th><th>EMAIL</th><th>DOCUMENTO</th><th>ETC</th><th></th></tr>";
    for (int i=0 ; i < clientes.Count; i++) {
    Cliente c = clientes[i];
    string fila = "<tr><td>" + c.Nombre + "</td><td>" + c.Apellido + "</td><td>" + c.Cedula + "</td><td>" + c.Documento + "</td><td>" +
    c.ETC + "</td><td><button class="" onclick=\"editarCliente('" + c.Codigo + "')\">EDITAR</button> <button onclick=\"eliminarCliente('" + cli.doc + "')\">ELIMINAR</button></td></td></tr>";
     
     function listarClientes() {
    let tabla = "<table BORDER><tr><th>NOMBRE</th><th> APELLIDO </th><th>CEDULA</th><th>EMAIL</th><th>ACTIVIDAD</th><th>FECHA DE ALTA</th><th></th></tr>";
    for (let i = 0; i < ArrCliente.length; i++) {
        let cli = ArrCliente[i];
        let fila = "<tr><td>" + cli.nom + "</td><td>" + cli.ape + "</td><td>" + cli.doc + "</td><td>" + cli.email + "</td><td>" + /*configurarActividad
    (cli.act) + "</td><td>" + cli.fechaAlta.toLocaleDateString() + "</td><td><button onclick=\"editarCliente('" + cli.doc + "')\">EDITAR</button> <button class="" onclick=\"eliminarCliente('" + c.Codigo + "')\">ELIMINAR</button></td></td></tr>";
        tabla += fila;
    }
    tabla += "</table>";
    Aca mandarlo al HTML => document.getElementById("divResListClientes").innerHTML = tabla;
    }
      
      */
}
