using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Business.Repository;
using WebAPI.Domain.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IBusinessBO _business;

        public StudentController(IBusinessBO business)
        {
            _business = business;
        }

        [HttpPost]
        [Route("AddStudent")]
        public ActionResult AddStudent(Student student)
        {
            _business.AddStudent(student);
            return Ok("Success");
        }

        [HttpGet]
        [Route("GetStudents")]
        public ActionResult<List<Student>> GetStudents()
        {
            return _business.GetStudents();
             
        }

        [HttpPost]
        [Route("GetStudent")]
        public ActionResult<Student> GetStudent(Student student)
        {
            return _business.GetStudent(student.StudentId);

        }

        [HttpPut]
        [Route("Modify")]
        public ActionResult<Student> Modify(Student student)
        {
            return _business.Modify(student.StudentId, student);
        }

        [HttpPut]
        [Route("Delete")]
        public ActionResult Delete(Student student)
        {
            var name =_business.Delete(student.StudentId);
            return Ok(name+"'s "+ "Data " +"Deleted "+ "Successfully");
        }
    }
}