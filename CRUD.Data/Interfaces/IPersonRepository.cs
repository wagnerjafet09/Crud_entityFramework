using CRUD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data.Interfaces
{
    public interface IPersonRepository
    {
        void Agregar(Person person);
        void Actualizar(Person person);
        void Eliminar(int personId);
        List<Person> Obtener();
        Person ObtenerPorId(int personId);
    }
}
