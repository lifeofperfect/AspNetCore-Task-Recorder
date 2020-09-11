using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Commander.Controllers
{   
    [Route("api/command")]
    [ApiController]
    public class CommandsControllers : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsControllers(ICommanderRepo repository)
        {
            _repository = repository;
        }



       // private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]

        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);

        }
    }
}