using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _respository;

        public CommandsController(ICommanderRepo respository)
        {
            _respository = respository;
        }

        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            IEnumerable<Command> commandItems = _respository.GetAllCommands();

            return Ok(commandItems);
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            Command command = _respository.GetCommandById(id);

            return command;
        }
    }
}