using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionbibliotecaMVC.Models
{
    public class Libro
    {
        private Guid _codigoLibro;
        private string _titulo;
        private Autor _autor;

        public Libro()
        {
            this._codigoLibro = new Guid("-1");
            this._titulo= "";
            this._autor = new Autor();
        }

        public Guid CodigoLibro
        {
            get
            {
                return _codigoLibro;
            }

            set
            {
                _codigoLibro = value;
            }
        }

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public Autor Autor
        {
            get
            {
                return _autor;
            }

            set
            {
                _autor = value;
            }
        }
    }
}