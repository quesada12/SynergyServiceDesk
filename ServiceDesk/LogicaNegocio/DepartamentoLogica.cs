using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class DepartamentoLogica
    {
        List<Departamento> departamentos = new List<Departamento>();

        public DepartamentoLogica()
        {
            departamentos = BD.ObtenerDepartamentos();
        }

        public void ActualizarLista()
        {
            departamentos = BD.ObtenerDepartamentos();
        }

        public Departamento CrearDepartamento(string nombre, string descripcion)
        {
            foreach (var departamento in departamentos)
            {
                if (departamento.Nombre_departamento.Equals(nombre))
                {
                    return null;
                }
            }
            Departamento nuevo = new Departamento() { Nombre_departamento = nombre, Descripcion = descripcion };
            BD.CrearDepartamento(nuevo);
            this.ActualizarLista();
            return nuevo;
        }

    }
}
