﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Tienda.controlador;
using Tienda.Modelo;
using Tienda.Vista;

namespace Tienda.controlador
{
    class ListadoControlador
    {

        private Productos objetoCD = new Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
    }
}
