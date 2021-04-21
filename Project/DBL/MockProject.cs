using System.Collections.Generic;
using Domain.Models;
//using Domain.Interfaces;
using BLL.Interfaces;

namespace DBL{
    
    public class MockProject : IProjectBLL{

        public void CreateCommand(Command cmd){
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd){
            throw new System.NotImplementedException();
        }

        
        public IEnumerable<Command> GetAllCommands(){
            var commands = new List<Command>{
                new Command{Id=0, Heading = "make dotnet project", Description="description of this project", Signature = "upit2r"},
                new Command{Id=1, Heading = "fasten the database", Description="with sql server", Signature = "upit2r"},
                new Command{Id=2, Heading = "create web api", Description="for what xd", Signature = "upit3r"}
            };

            return commands;
        }

        public Command GetCommandById(int id){
            return new Command{Id=0, Heading = "make dotnet project", Description="description of this project", Signature = "upit2r"};
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