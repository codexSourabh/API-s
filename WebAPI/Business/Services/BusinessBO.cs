using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Business.Repository;
using WebAPI.DataAccess.Repository;
using WebAPI.Domain.Models;

namespace WebAPI.Business.Services
{
    public class BusinessBO : IBusinessBO
    {
        private readonly IDAO _dao;

        public BusinessBO(IDAO dao)
        {
            _dao = dao;
        }

        public void AddStudent(Student student)
        {
            _dao.AddStudent(student);
        }

        public string Delete(string studentId)
        {
            return _dao.Delete(studentId);
        }

        public ActionResult<Student> GetStudent(string studentId)
        {
            return _dao.GetStudent(studentId);
        }

        public ActionResult<List<Student>> GetStudents()
        {
            return _dao.GetStudents();
        }

        public ActionResult<Student> Modify(string studentId, Student student)
        {
            return _dao.Modify(studentId, student);
        }
    }
}
