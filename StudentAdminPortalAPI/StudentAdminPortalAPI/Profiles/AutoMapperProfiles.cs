using DataModules = StudentAdminPortalAPI.DataModules;
using StudentAdminPortalAPI.Domain_Modules;
using AutoMapper;

namespace StudentAdminPortalAPI.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles() {

            CreateMap<DataModules.Student, Student>()
                .ReverseMap();

            CreateMap<DataModules.Gender, Gender>()
                .ReverseMap();

            CreateMap<DataModules.Address, Address>()
                .ReverseMap();
        }  
    }
}
