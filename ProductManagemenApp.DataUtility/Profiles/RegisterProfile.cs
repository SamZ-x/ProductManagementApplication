
/*
 * RegisterProfile : Automapping configuration.
 * File: RegisterProfile.cs
 * Author: Sam
 */

namespace ProductManagementApp.DataUtility
{
    using AutoMapper;
    using ProductManagementApp.Model;

    public class RegisterProfile : Profile
    {
        public RegisterProfile()
        {
            CreateMap<RegisterDTO, User>()
                .ForMember(dest => dest.Id, act => act.Ignore())
                .ForMember(dest => dest.Username, act => act.MapFrom(src => src.username))
                .ForMember(dest => dest.Password, act => act.MapFrom(src => src.password))
                .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.firstname))
                .ForMember(dest => dest.MiddleName, act => act.MapFrom(src => src.middlename))
                .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.lastname))
                .ForMember(dest => dest.Role, act => act.Ignore())
                .ForMember(dest => dest.Phone, act => act.MapFrom(src => src.phone))
                .ForMember(dest => dest.Email, act => act.MapFrom(src => src.email))
                .ForMember(dest => dest.Address, act => act.MapFrom(src => src.address))
                .ReverseMap();
        }
    }
}
