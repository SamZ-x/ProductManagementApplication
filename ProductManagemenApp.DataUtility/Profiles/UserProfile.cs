
/*
 * UserProfile : Automapping configuration.
 * File: UserProfile.cs
 * Author: Sam
 */

namespace ProductManagementApp.DataUtility
{
    using AutoMapper;
    using ProductManagementApp.Model;

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Username, act => act.MapFrom(src => src.Username))
                .ForMember(dest => dest.Token, act => act.Ignore())
                .ForMember(dest => dest.Firstname, act => act.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Middlename, act => act.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.Lastname, act => act.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Role, act => act.MapFrom(src => src.Role))
                .ForMember(dest => dest.Phone, act => act.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                .ForMember(dest => dest.Address, act => act.MapFrom(src => src.Address))
                .ForMember(dest => dest.CreatedBy, act => act.MapFrom(src => src.CreatedBy))
                .ForMember(dest => dest.CreatedDate, act => act.MapFrom(src => src.CreatedDate))
                .ForMember(dest => dest.UpdatedBy, act => act.MapFrom(src => src.UpdatedBy))
                .ForMember(dest => dest.UpdatedDate, act => act.MapFrom(src => src.UpdatedDate))
                .ReverseMap();
        }
    }
}
