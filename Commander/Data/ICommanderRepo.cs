using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        Task<IEnumerable<Command>> Search(string searchQuery);
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);

        bool SaveChanges();
        void CreateCommand(Command command);
        void UpdateCommand(Command command);
        void DeleteCommand(Command command);
    }
}
