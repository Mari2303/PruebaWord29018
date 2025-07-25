﻿using AutoMapper;
using Entity.Model;
using Entity.Dtos.ClientesDTO;

namespace Utilities.Mappers.Profiles
{
    public class RolProfile : Profile
    {
        public RolProfile()
        {
            // Mapeo de Rol a RolDto y viceversa
            CreateMap<Rol, RolDto>().ReverseMap();
        }
    }
}