// Mappings/AutoMapperProfile.cs
using AutoMapper;
using TodoApi.Models;
using TodoApi.Dtos;

namespace TodoApi.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();
        }
    }
}
