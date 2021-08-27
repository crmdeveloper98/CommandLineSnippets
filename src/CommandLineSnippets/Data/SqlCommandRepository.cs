using System.Collections.Generic;
using System.Linq;
using CommandLineSnippets.Models;

namespace CommandLineSnippets.Data
{
    public class SqlCommandRepository : ICommandRepository
    {
        private readonly AppDbContext _context;

        public SqlCommandRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandSnippets.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandSnippets.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}