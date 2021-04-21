using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace BLL.Interfaces{
    public interface IProjectBLL{
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}