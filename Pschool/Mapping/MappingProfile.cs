using AutoMapper;
using Pschool.Core.DTOs;
using Pschool.Infrastructure.Models;
using Student = Pschool.Infrastructure.Models.Student;

namespace Pschool.Mapping;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Parent, ParentDto>().ReverseMap();
        CreateMap<Student, StudentDto>().ReverseMap();
    }
}