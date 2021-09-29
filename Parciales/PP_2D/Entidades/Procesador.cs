﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Procesador
    {
        private string operador;
        private DateTime fecha;
        private static Procesador procesador; //esto es para el singleton
        private List<Sesion> sesiones;
        private List<Puesto> puestos;
        private List<Cliente> clientes;


        //hacer todo lo del singleton



        //añadir clientes

        public void AniadirPuesto(Puesto puesto)
        {
            this.puestos.Add(puesto);
        }

        public void AniadirCliente(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }


        public bool AbrirSesion(Puesto puesto, Cliente cliente, Enumerados.TiposDeSesion tipo, String numero) 
        {
            bool retorno = false;

            switch (tipo)
            {
                case Enumerados.TiposDeSesion.conexion:
                    if (cliente == (Computadora)puesto)
                    {
                        Conexion conexion = new Conexion(puesto, cliente);
                        this.sesiones.Add(conexion);
                        retorno = true;
                    }
                    break;
                case Enumerados.TiposDeSesion.llamada:
                    if(numero.Length == 12)
                    {
                        Llamada llamada = new Llamada(puesto, cliente, numero);
                        this.sesiones.Add(llamada);
                        retorno = true;                       
                    }
                    break;
            }
            return retorno;
        }


        public void CerrarSesion(Sesion sesion)
        {
            int i = 0;
            foreach (Sesion item in this.sesiones)
            {
                if(item == sesion)
                {
                    Historico.Sesiones.Add(sesion);
                    this.sesiones.RemoveAt(i);
                }
                i++;
            }
        }




    }
}