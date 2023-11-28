using API_crud.Models.Data;
using API_crud.Models.Dtos;
using AutoMapper;

namespace API_crud.Models.Profiles
{
    public class StudentsProfile : Profile
    {
        public StudentsProfile()
        {
            CreateMap<Student, StudentsDTO>().ForMember(stuDto => stuDto.GradeName, action
            => action.MapFrom(stu => stu.CurrentGrade.GradeName));
            CreateMap<StudentsDTO, Student>();
        }
    }
}
