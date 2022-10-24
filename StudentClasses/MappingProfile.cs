using AutoMapper;
using StudentClasses.Entities.DataTransferObjects;
using StudentClasses.Entities.Models;

namespace StudentClasses
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Subject, SubjectDto>()
                .ForMember(c => c.FullDescription,
                    opt => opt.MapFrom(x => string.Join(' ', x.Description, x.City)));

            CreateMap<UserForRegistrationDto, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
