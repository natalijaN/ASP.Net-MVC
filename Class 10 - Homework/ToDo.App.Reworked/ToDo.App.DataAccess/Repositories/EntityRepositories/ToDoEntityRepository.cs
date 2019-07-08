using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Repositories.EntityRepositories
{
    public class ToDoEntityRepository : IRepository<ToDo>
    {
        private ToDoDbContext _context;
        public ToDoEntityRepository(ToDoDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            ToDo toDo = _context.ToDos.FirstOrDefault(x => x.Id == id);
            if (toDo != null) _context.ToDos.Remove(toDo);
            _context.SaveChanges();
        }

        public List<ToDo> GetAll()
        {
            return _context.ToDos.ToList();
        }

        public ToDo GetById(int id)
        {
            return _context.ToDos.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(ToDo entity)
        {
            _context.ToDos.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(ToDo entity)
        {
            ToDo todo = _context.ToDos.FirstOrDefault(x => x.Id == entity.Id);
            if (todo != null)
            {
                entity.Id = todo.Id;
                _context.ToDos.Update(entity);
            }
        }
    }
}
