using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            List<Command> commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife & chopping board"},
                new Command{Id=2, HowTo="Make a cup of tea", Line="Place teabag in cup", Platform="Kettle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            
            return GetAppCommands().First(command => command.Id == 0);
        }
    }
}