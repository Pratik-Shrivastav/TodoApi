using AutoMapper;
using TodoApi.Models;
using TodoApi.Dtos;

namespace TodoApi.AutoMapper
{
    public class TodoItemProfile : Profile
    {
        public TodoItemProfile()
        {
            CreateMap<TodoItem, TodoItemDTO>();

            CreateMap<TodoItemDTO, TodoItem>()
                .ForMember(dest => dest.Secret, opt => opt.Ignore());
        }
    }
}
