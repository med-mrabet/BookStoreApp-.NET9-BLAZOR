using AutoMapper;
using BookStoreApp.API.Dtos.Author;
using BookStoreApp.Data.Models;

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CreateAuthorDto , Author>().ReverseMap();
        }
    }
}
