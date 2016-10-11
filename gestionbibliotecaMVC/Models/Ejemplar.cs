using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionbibliotecaMVC.Models
{
    public class Ejemplar:Libro
    {
        private Guid _codigoEjemplar;
        private string _isbn;
        private int _nPaginas;
        private DateTime _fPublicacion;
        private Editorial editorial;
        private IList<Prestamo> _prestamos;

        public Guid CodigoEjemplar
        {
            get
            {
                return _codigoEjemplar;
            }

            set
            {
                _codigoEjemplar = value;
            }
        }

        public string Isbn
        {
            get
            {
                return _isbn;
            }

            set
            {
                _isbn = value;
            }
        }

        public int NPaginas
        {
            get
            {
                return _nPaginas;
            }

            set
            {
                _nPaginas = value;
            }
        }

        public DateTime FPublicacion
        {
            get
            {
                return _fPublicacion;
            }

            set
            {
                _fPublicacion = value;
            }
        }

        public Editorial Editorial
        {
            get
            {
                return editorial;
            }

            set
            {
                editorial = value;
            }
        }

        public IList<Prestamo> Prestamo
        {
            get
            {
                return _prestamos;
            }

            set
            {
                _prestamos = value;
            }
        }

        public Ejemplar()
        {
            this._codigo = new Guid();
            this._isbn = "";
            this._nPaginas = 0;
            this.FPublicacion = new DateTime();
            this.Editorial = new Editorial();
            this._prestamos = new Prestamo();
        }
    }
}