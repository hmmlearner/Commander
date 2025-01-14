﻿using Commander.Models;
using System.Security.Cryptography;

namespace Commander.Data
{
    public class SqlCommandRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommandRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            if(command == null) throw new ArgumentNullException(nameof(command));

            _context.Commands.Add(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdateCommand(Command command)
        {
            //nothing
        }

        public void DeleteCommand(Command command)
        {
            if (command == null) throw new ArgumentNullException(nameof(command));

            _context.Commands.Remove(command);
        }

    }
}
