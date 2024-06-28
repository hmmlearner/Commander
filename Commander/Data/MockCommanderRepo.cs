using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "test0", Line = "testline0", Platform = "platform0" },
                new Command { Id = 1, HowTo = "test1", Line = "testline1", Platform = "platform1" },
                new Command { Id = 2, HowTo = "test2", Line = "testline2", Platform = "platform2" }
            };
            return commands;
        }

         public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "test", Line = "testline", Platform = "platform" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            throw new NotImplementedException();
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            throw new NotImplementedException();
        }

        bool ICommanderRepo.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void ICommanderRepo.UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
