using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionbibliotecaMVC.Models
{
    public class Editorial
    {
        private Guid _codigo;
        private string _nombre;
        public Editorial()
        {
            this._codigo = new Guid("-1");
            this._nombre = "";
        }
        public Guid Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }
    }
}