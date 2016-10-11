using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionbibliotecaMVC.Models
{
    public class Usuario
    {
        private Guid _codigoUsuario;
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private string _password;
        private string _nickName;
        private string _email;
        private string _dni;
        private IList<Prestamo> _prestamos;
        public Usuario()
        {
            _codigoUsuario = new Guid("-1");
            _nombre = "";
            _apellidos = "";
            _fechaNacimiento = new DateTime();
            _password = "";
            _nickName = "";
            _email = "";
            _dni = "";
            this._prestamos = null;
        }
        public Guid CodigoUsuario
        {
            get
            {
                return _codigoUsuario;
            }

            set
            {
                _codigoUsuario = value;
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

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }

            set
            {
                _apellidos = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }

            set
            {
                _fechaNacimiento = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public string NickName
        {
            get
            {
                return _nickName;
            }

            set
            {
                _nickName = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Dni
        {
            get
            {
                return _dni;
            }

            set
            {
                _dni = value;
            }
        }

        public IList<Prestamo> Prestamos
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
    }
}