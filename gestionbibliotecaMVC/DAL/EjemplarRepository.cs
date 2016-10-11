using gestionbibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionbibliotecaMVC.DAL
{
    interface EjemplarRepository
    {   
         IList<Ejemplar> getAll();

        Ejemplar getById(Guid codigo);

        Ejemplar update(Ejemplar ejemplar);

        void delete(Guid codigo);

        Guid create(Ejemplar ejemplar);
    }
}
