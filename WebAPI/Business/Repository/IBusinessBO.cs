using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Domain.Models;

namespace WebAPI.Business.Repository
{
    public interface IBusinessBO
    {
         void AddStudent(Student student);
         ActionResult<List<Student>> GetStudents();
        ActionResult<Student> GetStudent(string studentId);
        ActionResult<Student> Modify(string studentId, Student student);
        string Delete(string studentId);
    }
}
