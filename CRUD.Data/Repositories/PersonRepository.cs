using CRUD.Data.Context;
using CRUD.Data.Entities;
using CRUD.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly CRUDContext context;

        public PersonRepository(CRUDContext context)
        {
            this.context = context;
        }

        public void Actualizar(Person person)
        {
            context.Person.Update(person);
            context.SaveChanges();
        }

        public void Agregar(Person person)
        {
            context.Person.Add(person);
            context.SaveChanges();
        }

        public void Eliminar(int personId)
        {
            var person = this.ObtenerPorId(personId);
            context.Person.Remove(person);
            context.SaveChanges();
        }

        public List<Person> Obtener()
        {
            return context.Person.ToList();
        }

        public Person ObtenerPorId(int personId)
        {
            return context.Person.Find(personId);
        }
    }
}
