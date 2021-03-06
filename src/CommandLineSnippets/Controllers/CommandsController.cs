using System.Collections.Generic;
using CommandLineSnippets.Data;
using CommandLineSnippets.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandLineSnippets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepository _repository;

        public CommandsController(ICommandRepository repository)
        {
            _repository = repository;
        }     

        [HttpGet]   
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id:int}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }

            return Ok(commandItem);
        }        
    }
}