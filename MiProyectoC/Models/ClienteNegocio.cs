using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyectoC.Models
{
    public class ClienteNegocio
    {
        //PROPIEDADES
        private static List<Cliente> MisClientes = new List<Cliente>();



        // CONSTRUCTOR
        public ClienteNegocio()
        {
            if (MisClientes.Count == 0)
            {
                this.agregar(001, "Lionel", "Messi", "20456789", "liomessi@yahoo.com.ar");
                this.agregar(002, "Homero", "Thomson", "25789123", "homer@hotmail.com");
                this.agregar(003, "Diego", "Maradona", "10123678", "maradona@gmail.com");
                this.agregar(004, "Bart", "Simpsons", "40987654", "lossimpsonitos@outlook.com.ar");
                this.agregar(005, "Mauro", "Icardi", "36654321", "icardeador@hotmail.com");
            }
        }



        // METODOS


        public List<Cliente> listado()                       // LISTADO DE CLIENTES
        {
            return MisClientes;
        }


        public Cliente getCliente(int id)                    // GETCLIENTE
        {
            foreach (Cliente cli in MisClientes)
            {
                if (cli.Id == id)
                {
                    return cli;
                }
            }
            return null;
        }


        public void agregar( int id, string nombre, string apellido, string dni, string email)                     // AGREGAR CLIENTE
        {
            MisClientes.Add(new Cliente() { Id = id, Nombre = nombre, Apellido = apellido, Dni = dni, Email = email });
        }


        public void actualizar(Cliente c)                   // ACTUALIZAR CLIENTE
        {
            foreach (Cliente cli in MisClientes)
            {
                if (c.Id == cli.Id)
                {
                    cli.Id = c.Id;
                    cli.Nombre = c.Nombre;
                    cli.Apellido = c.Apellido;
                    cli.Dni = c.Dni;
                    cli.Email = c.Email;
                    break;
                }
            }
        }


        public void borrar(int id)                         // BORRAR CLIENTE
        {
            foreach (Cliente cli in MisClientes)
            {
                if (cli.Id == id)
                {
                    MisClientes.Remove(cli);
                    break;
                }
            }
        }

    }
}