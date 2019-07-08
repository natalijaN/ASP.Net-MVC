using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain;

namespace ToDoApp.DataAccess.Repositories.EntityRepositories
{
    public class SubTaskEntityRepository : IRepository<SubTask>
    {
        private ToDoDbContext _context;
        public SubTaskEntityRepository(ToDoDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            SubTask subtask = _context.SubTasks.FirstOrDefault(x => x.Id == id);
            if (subtask != null) _context.SubTasks.Remove(subtask);
            _context.SaveChanges();
        }

        public List<SubTask> GetAll()
        {
            return _context.SubTasks.ToList();
        }

        public SubTask GetById(int id)
        {
            return _context.SubTasks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(SubTask entity)
        {
            _context.SubTasks.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(SubTask entity)
        {
            SubTask subtask = _context.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if (subtask != null)
            {
                entity.Id = subtask.Id;
                _context.SubTasks.Update(entity);
            }
        }
    }
}
