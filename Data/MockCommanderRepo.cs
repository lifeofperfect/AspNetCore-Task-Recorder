using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{Id=1, HowTo="first", Line="first line", Platform="first platform"},
                new Command{Id=2, HowTo="Second", Line="Second Line", Platform="Second platform"},
                new Command{Id=3, HowTo="third", Line="third line", Platform="third platform"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 4, HowTo = "Fourth How", Line = "fourth line", Platform = "fourth plat" };
        }
    }
}