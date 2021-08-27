using System.Collections.Generic;
using CommandLineSnippets.Models;

namespace CommandLineSnippets.Data
{
    public interface ICommandRepository
    {
         bool SaveChanges();
         IEnumerable<Command> GetAllCommands();
         Command GetCommandById(int id);
         void CreateCommand(Command cmd);
         void UpdateCommand(Command cmd);
         void DeleteCommand(Command cmd);
    }
}