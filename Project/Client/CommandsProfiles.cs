using AutoMapper;
using Client;
using Domain.Models;

namespace Project.Profiles{
    public class CommandsProfile : Profile{
        public CommandsProfile(){
            //source -->>>> target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}