using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioProg2.Dominio
{
    public class Empresa
    {
        private List<Publicidad> publicidades;
        //private List<PublicidadComercial> pubComerciales;
        //private List<AvisosTrabajo> avTrabajos;
        private List<Cliente> clientes;
        //private List<Cliente> clienteMayor;
        //private List<Publicidad> pubAListar;
        private int ultimoCodigo;
        private int ultimoNumero;
        private int numPublicidad;

        // Crearmetodos para los List comentados

        public Empresa()
        {
            publicidades = new List<Publicidad>();
            //pubComerciales = new List<PublicidadComercial>();
            //avTrabajos = new List<AvisosTrabajo>();
            clientes = new List<Cliente>();
            //clienteMayor = new List<Cliente>();
            //pubAListar = new List<Publicidad>();
            ultimoCodigo = 0;
            ultimoNumero = 0;
            numPublicidad = 0;
        }

       
        public static Empresa Instancia { get; set; } = new Empresa();

        public void agregarCliente(Cliente cliente)
        {
            cliente.Codigo = ++ultimoCodigo;
            cliente.FechaAlta = DateTime.Today;
            clientes.Add(cliente);
        }

        public void agregarPublicidad(Publicidad publicidad)
        {
            publicidad.Numero = ++ultimoNumero;
            publicidades.Add(publicidad);
        }

        public void agregarAvisoTrabajo(AvisosTrabajo publicidad)
        {
            publicidad.Numero = ++ultimoNumero;
            publicidad.Cliente.CantidadPub = ++numPublicidad;
            publicidades.Add(publicidad);
        }

        public void agregarPublicidadComercial(PublicidadComercial publicidad)
        {
            publicidad.Numero = ++ultimoNumero;
            publicidad.Cliente.CantidadPub = ++numPublicidad;
            publicidades.Add(publicidad);
        }

        /*
        public void agregarPubComercial(PublicidadComercial pubComercial)
        {
            pubComerciales.Add(pubComercial);
        }

        public void agregarAvTrabajo (AvisosTrabajo avisoTrabajo)
        {
            avTrabajos.Add(avisoTrabajo);
        }
        */

        public List<Cliente> obtenerCliente()
        {
            return clientes;
        }
        public List<Publicidad> obtenerPublicidad()
        {
            return publicidades;
        }

        public List<PublicidadComercial> ObtenerPublicidadesComercial()
        {
            List<PublicidadComercial> resultado = new List<PublicidadComercial>();
            foreach (Publicidad publicidad in publicidades)
            {
              
                if (publicidad is PublicidadComercial)
                {
                    resultado.Add((PublicidadComercial)publicidad);
                }
            }
            return resultado;
        }
        public List<AvisosTrabajo> ObtenerAvisoTrabajo()
        {
            List<AvisosTrabajo> resultado = new List<AvisosTrabajo>();
            foreach (Publicidad publicidad in publicidades)
            {
                if (publicidad is AvisosTrabajo)
                {
                    resultado.Add((AvisosTrabajo)publicidad);
                }
            }
            return resultado;
        }

        public List<Publicidad> obtenerPubOrdenadasXFecha()
        {
            List<Publicidad> pubADevolver = new List<Publicidad>(this.publicidades);
            publicidades.Sort(new ComparadorDeFechas());
            pubADevolver = publicidades;
            return pubADevolver;
        }



        //public List<PublicidadComercial> obtenerPubComerciales()
        //{
        //    return pubComerciales;
        //}

        //public List<AvisosTrabajo> obtenerAvisos()
        //{
        //    return avTrabajos;
        //}

        /*
        public void eliminarCliente1(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        public void eliminarCliente2(int codigo)
        {

            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente cli = clientes[i];
                if (codigo == cli.Codigo)
                {
                    clientes.Remove(cli);
                    return;
                }
            }

        }
        public void eliminarPublicidad1(Publicidad publicidad)
        {
            publicidades.Remove(publicidad);
        }

        public void eliminarPublicidad2(int numero)
        {

            for (int i=0; i < publicidades.Count; i++)
            {
                Publicidad pub = publicidades[i];
                if (numero == pub.Numero)
                {
                    publicidades.Remove(pub);
                    return;
                }
            }
            
        }

        public void eliminarPubComercial1(PublicidadComercial pubComercial)
        {
            pubComerciales.Remove(pubComercial);
        }

        public void eliminarPubComercial2(int numero)
        {

            for (int i = 0; i < pubComerciales.Count; i++)
            {
                PublicidadComercial pubC = pubComerciales[i];
                if (numero == pubC.Numero)
                {
                    pubComerciales.Remove(pubC);
                    return;
                }
            }

        }

        public void eliminarAvTrabajo1(AvisosTrabajo avTrabajo)
        {
            avTrabajos.Remove(avTrabajo);
        }

        public void eliminarAvTrabajo2(int numero)
        {

            for (int i = 0; i < avTrabajos.Count; i++)
            {
                AvisosTrabajo avT = avTrabajos[i];
                if (numero == avT.Numero)
                {
                    avTrabajos.Remove(avT);
                    return;
                }
            }

        }
        */

        public void modificarAvisoTrabajo(int num, AvisosTrabajo pDatosModificados)
        {
            AvisosTrabajo pubAModificar = buscarAvTrabajoXNumero(num);
            pubAModificar.FechaAlta = pDatosModificados.FechaAlta;
            pubAModificar.FechaInicio = pDatosModificados.FechaInicio;
            pubAModificar.FechaFin = pDatosModificados.FechaFin;
            pubAModificar.Titulo = pDatosModificados.Titulo;
            pubAModificar.Detalle = pDatosModificados.Detalle;
            pubAModificar.Cliente = pDatosModificados.Cliente;
        }

        public void modificarPubComercial(int num, PublicidadComercial pDatosModificados)
        {
            PublicidadComercial pubAModificar = buscarPubComercialXNumero(num);
            pubAModificar.FechaAlta = pDatosModificados.FechaAlta;
            pubAModificar.FechaInicio = pDatosModificados.FechaInicio;
            pubAModificar.Imagen = pDatosModificados.Imagen;
            pubAModificar.FechaFin = pDatosModificados.FechaFin;
            pubAModificar.Titulo = pDatosModificados.Titulo;
            pubAModificar.Detalle = pDatosModificados.Detalle;
            pubAModificar.Cliente = pDatosModificados.Cliente;
        }



        public Publicidad buscarPublicidadXNumero(int num)
        {
            for (int i = 0; i < publicidades.Count; i++)
            {
                Publicidad pub = publicidades[i];
                if (num == pub.Numero)
                {
                    return pub;
                }

            }
            return null;
        }

        public PublicidadComercial buscarPubComercialXNumero(int num) 
        {
            List<PublicidadComercial> resultado = new List<PublicidadComercial>();
            foreach (Publicidad publicidad in publicidades)
            {
                if (publicidad is PublicidadComercial)
                {
                    resultado.Add((PublicidadComercial)publicidad);
                }
            }
            
            for (int i=0; i < resultado.Count; i++)
            {
                PublicidadComercial pub = resultado[i];
                if (num == pub.Numero)
                {
                    return pub;
                }
            }
            return null;
        }

        public AvisosTrabajo buscarAvTrabajoXNumero(int num)
        {
            List<AvisosTrabajo> resultado = new List<AvisosTrabajo>();
            foreach (Publicidad publicidad in publicidades)
            {
                if (publicidad is AvisosTrabajo)
                {
                    resultado.Add((AvisosTrabajo)publicidad);
                }
            }

            for (int i = 0; i < resultado.Count; i++)
            {
                AvisosTrabajo pub = resultado[i];
                if (num == pub.Numero)
                {
                    return pub;
                }
            }
            return null;
        }





        public void modiificarCliente(int codigo, Cliente cDatosModificados)
        {
            Cliente cliAModificar = buscarClienteXCodigo(codigo);
            cliAModificar.Nombre = cDatosModificados.Nombre;
            cliAModificar.TipoDoc = cDatosModificados.TipoDoc;
            cliAModificar.Documento = cDatosModificados.Documento;
            cliAModificar.Direccion = cDatosModificados.Direccion;
            cliAModificar.Telefono = cDatosModificados.Telefono;
        }

        //public void modiificarCliente(int codigo, Cliente datosModificados)
        //{
        //    throw new NotImplementedException();
        //}


        public Cliente buscarClienteXCodigo(int codigo)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente cli = clientes[i];
                if (codigo == cli.Codigo)
                {
                    return cli;
                }

            }
            return null;
        }


        public int CalcularPubXCliente(int cod)
        {
            int contadora = 0;
            for (int i = 0; i < publicidades.Count; i++)
            {
                Cliente c = publicidades[i].Cliente;
                if (c.Codigo == cod)
                {
                    contadora++;
                }
            }
            return contadora;
        }

        public List<Cliente> clienteMayorCantPub()
        {
            List<Cliente> clienteMayor = new List<Cliente>();
            int numMayor = 0;
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente c = clientes[i];
                int cantPubCli = CalcularPubXCliente(c.Codigo);
                if (cantPubCli == numMayor)
                {
                    clienteMayor.Add(c);
                }
                if (cantPubCli > numMayor)
                {
                    clienteMayor.Clear();
                    clienteMayor.Add(c);
                }
            }
            return clienteMayor;
        }


        //public int calcularCostoPub (DateTime fecha, int numPub)
        //{

        //    for (int i = 0; i < pubComerciales.Count; i++)
        //    {
        //        Publicidad pub = publicidades[i];
        //        if (pub.Numero == numPub)
        //        {
        //            TimeSpan periodo = new TimeSpan();
        //            periodo = pub.calcularPorFechaDada(fecha, pub);
        //            int precioBase = periodo * pub.Detalle;
        //            int precioExtra = periodo * 20;
        //            int precioTotal = precioBase + precioExtra;
        //            return precioTotal;
        //        }
        //    }

        //    for (int i = 0; i < avTrabajos.Count; i++)
        //    {
        //        Publicidad pub = publicidades[i];
        //        if (pub.Numero == numPub)
        //        {
        //            TimeSpan periodo = new TimeSpan();
        //            periodo = pub.calcularPorFechaDada(fecha, pub);
        //            int detalle = pub.Detalle.Length;
        //            if (detalle <= 50)
        //            {
        //                detalle = 0;
        //            }
        //            else if (detalle > 50 && detalle <= 100)
        //            {
        //                detalle = 40;
        //            }
        //            else if (detalle > 100 && detalle <= 500)
        //            {
        //                detalle = 70;
        //            }
        //            else if (detalle > 500 && detalle <= 1000)
        //            {
        //                detalle = 100;
        //            }
        //            else
        //            {
        //                return 0;
        //            }


        //            if (detalle != 0)
        //            {
        //                detalle *= periodo;
        //            }
        //            return detalle;

        //        }


        //    }

        //    return null;
        //    }

        //public Publicidad[] obtenerArregloPubDeCliente (int codigo)
        //{
        //    int contadora = 0;
        //    for (int i = 0; i< publicidades.Count; i++)
        //    {
        //        Publicidad pub = publicidades[i];
        //        if (codigo == pub.Cliente.Codigo)
        //        {
        //            contadora++;
        //        }
        //    }
        //    Publicidad[] arrPub = new Publicidad[contadora];
        //    int controladora = 0;
        //    for (int i = 0; i < publicidades.Count; i++)
        //    {
        //        Publicidad pub = publicidades[i];
        //        if (codigo == pub.Cliente.Codigo)
        //        {
        //            arrPub[controladora]= pub;
        //            controladora++;
        //        }
        //    }
        //    return arrPub;
        //}

        public List<Publicidad> listaPubXCliente(int codigo)
        {
            List<Publicidad> pubCliente = new List<Publicidad>();
            for (int i = 0; i < publicidades.Count; i++)
            {
                Publicidad p = publicidades[i];
                if (codigo == p.Cliente.Codigo)
                {
                    pubCliente.Add(p);
                }
            }
            return pubCliente;
        }

        public void cerrarFechaPublicidad(int num)
        {
            for (int i = 0; i < publicidades.Count; i++)
            {
                Publicidad p = publicidades[i];
                if (num == p.Numero)
                {
                    p.FechaFin = DateTime.Today;
                }
            }
        }

       

        public int calcularPubXCliente(int codigo)
        {
            int contadora = 0;
            for (int i = 0; i < publicidades.Count; i++)
            {
                Publicidad pub = publicidades[i];
                if (codigo == pub.Cliente.Codigo)
                {
                    contadora++;
                }
                return contadora;
            }
            return 0;
        }

        public bool validarDatosCliente(Cliente c)
        {
            bool validacion=true;
            c.Nombre.Trim().Split(" ");
            if (c.Nombre.Trim().Length<3&& c.Nombre.Trim().Length > 20)
            {
                validacion = false;
            }
            if (Convert.ToString(c.Documento).Length < 8 && Convert.ToString(c.Documento).Length > 8)
            {
                validacion = false;
            }
            if (c.Direccion.Length < 5 && c.Direccion.Length > 50)
            {
                validacion = false;
            }
            if (Convert.ToString(c.Telefono).Length > 15 && Convert.ToString(c.Telefono).Length < 8)
            {
                validacion = false;
            }
            return validacion;
        }

        public bool validarPublicidad(Publicidad p)
        {
            bool validacion = true;
            if (p.Titulo.Length < 1 && p.Titulo.Length > 40)
            {
                validacion = false;
            }
            if (p.Detalle.Length < 1 && p.Detalle.Length < 1000)
            {
                validacion = false;
            }
            return validacion;
        }

        public bool validarPublicidadComercial(PublicidadComercial p)
        {
            bool validacion = true;
            if (p.Titulo.Length < 1 && p.Titulo.Length > 40)
            {
                validacion = false;
            }
            if (p.Detalle.Length < 1 && p.Detalle.Length < 1000)
            {
                validacion = false;
            }
            return validacion;
        }

        public bool validarAvisoTrabajo(AvisosTrabajo p)
        {
            bool validacion = true;
            if (p.Titulo.Length < 1 && p.Titulo.Length > 40)
            {
                validacion = false;
            }
            if (p.Detalle.Length < 1 && p.Detalle.Length < 1000)
            {
                validacion = false;
            }
            return validacion;
        }

        //function validarDatosCliente(datosCliente)
        //{
        //    let mensaje = "";
        //    let Arr = datosCliente.nom.trim().split(' ');

        //    let cantCaracters = 0;
        //    for (let i = 0; i < Arr.length; i++)
        //    {
        //        cantCaracters += Arr[i].length;
        //    }


        //    if (datosCliente.nom.trim().length < 4)
        //    {
        //        mensaje += "El nombre debe tener cuatro o más caracteres<br>";
        //    }
        //    if (datosCliente.nom.trim().length > 7)
        //    {
        //        mensaje += "La clave debe tener 8  o más caracteres<br>";
        //    }
        //    if (isNaN(datosCliente.doc.length < 7 && datosCliente.doc.length > 9))
        //    {
        //        mensaje += "Ingrese un documento válido<br>";
        //    }


        //    //otras validacion
        //    if (mensaje.length > 0)
        //    {
        //        document.getElementById("mensajeValidar").innerHTML = mensaje;
        //        return false;
        //    }
        //    else
        //    {
        //        document.getElementById("mensajeValidar").innerHTML = "";
        //        return true;
        //    }
    }



    }


  
    





