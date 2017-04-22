using MiProyectoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiProyectoC.Controllers
{
    public class ClientesController : Controller
    {

        // GET: Clientes

        public ActionResult ListadoClientes()
        {
            ClienteNegocio cn = new ClienteNegocio();
            var listado = cn.listado();

            return View(listado);
        }


        public ActionResult NuevoCliente()
        {
            return View();
        }


        [HttpPost]
        public ActionResult NuevoCliente(Cliente c)
        {
            ClienteNegocio cn = new ClienteNegocio();
            cn.agregar(c.Id, c.Nombre, c.Apellido, c.Dni, c.Email);

            return View(cn);
        }


        public ActionResult DetalleCliente(int id)
        {
            ClienteNegocio cn = new ClienteNegocio();
            Cliente c = cn.getCliente(id);

            return View(c);
        }


        public ActionResult BorraCliente(int id)
        {
            ClienteNegocio cn = new ClienteNegocio();
            cn.borrar(id);

            return RedirectToAction("ListadoClientes");
        }


        public ActionResult EditarCliente(int id)
        {
            ClienteNegocio cn = new ClienteNegocio();

            return View(cn.getCliente(id));
        }


        [HttpPost]
        public ActionResult EditarCliente(Cliente c)
        {
            ClienteNegocio cn = new ClienteNegocio();
            cn.actualizar(c);

            return RedirectToAction("ListadoClientes");
        }


    }
}