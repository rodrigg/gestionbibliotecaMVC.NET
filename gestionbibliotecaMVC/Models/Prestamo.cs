using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestionbibliotecaMVC.Models
{
    public class Prestamo
    {
        private Guid codigo;
        private DateTime fRecogida;
        private DateTime fDevolucion;
        private Usuario usuario;
        private Ejemplar ejemplar;
    }
}