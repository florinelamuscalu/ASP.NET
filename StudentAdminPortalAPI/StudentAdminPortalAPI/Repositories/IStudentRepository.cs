
using StudentAdminPortalAPI.DataModules;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>>GetStudentsAsync();
        
    }
}