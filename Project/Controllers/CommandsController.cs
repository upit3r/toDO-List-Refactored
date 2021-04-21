using System.Collections.Generic;
using DBL;
using Domain.Models;
using Client;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BLL.Interfaces;

namespace Project.Controllers{
    //api commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase{
        private readonly IProjectBLL _repository;
        private readonly IMapper _mapper;

        public CommandsController(IProjectBLL repository, IMapper mapper){
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockProjectRepository _repository = new MockProjectRepository();
        
        //GET api/commands - all commands without id
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands(){
            var commandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }
        

        //GET api/commands/{id} ex:api/commands/5
        [HttpGet("{id}", Name= "GetCommandById")]

        public ActionResult <CommandReadDto> GetCommandById(int id){
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null){
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto){
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);


            return CreatedAtRoute(nameof(GetCommandById), new {Id = commandReadDto.Id}, commandReadDto);
            //return Ok(commandModel);
        }

        //PUT api/commands/{id} 
        [HttpPut("{id}")]
        public ActionResult UpdateCommand (int id, CommandUpdateDto commandUpdateDto){
            var commandModelFromRepository = _repository.GetCommandById(id);
            if(commandModelFromRepository == null){
                return NotFound();
            }
            _mapper.Map(commandUpdateDto, commandModelFromRepository);

            _repository.UpdateCommand(commandModelFromRepository);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/command/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id){
            var commandModelFromRepository = _repository.GetCommandById(id);
            if(commandModelFromRepository == null){
                return NotFound();
            }
            _repository.DeleteCommand(commandModelFromRepository);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}