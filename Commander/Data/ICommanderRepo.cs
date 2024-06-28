
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        public bool SaveChanges();
        public IEnumerable<Command> GetAllCommands();
        public Command GetCommandById(int id);

        public void CreateCommand(Command command);

        public void UpdateCommand(Command command);

        public void DeleteCommand(Command command);

    }
}
