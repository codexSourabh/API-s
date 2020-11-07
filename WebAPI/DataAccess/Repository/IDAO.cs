using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Domain.Models;

namespace WebAPI.DataAccess.Repository
{
    public interface IDAO
    {
        void AddStudent(Student student);
        ActionResult<List<Student>> GetStudents();
        ActionResult<Student> GetStudent(string studentId);
        ActionResult<Student> Modify(string studentId, Student student);
        string Delete(string studentId);
    }
}
