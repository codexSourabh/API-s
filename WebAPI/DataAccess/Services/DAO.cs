using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DataAccess.Repository;
using WebAPI.Domain.Models;

namespace WebAPI.DataAccess.Services
{
    public class DAO : IDAO
    {
        StudentDBContext DBContext = new StudentDBContext();
        public void AddStudent(Student student)
        {
            DBContext.Student.Add(student);
            DBContext.SaveChanges();
        }

        public string Delete(string studentId)
        {
            Student student = DBContext.Student.Find(studentId);
            string name = student.StudentName;
            DBContext.Student.Remove(student);
            DBContext.SaveChanges();
            return name;
        }

        public ActionResult<Student> GetStudent(string studentId)
        {
            Student student = DBContext.Student.Find(studentId);
            return student;
        }

        public ActionResult<List<Student>> GetStudents()
        {
            return DBContext.Student.ToList();
        }

        public ActionResult<Student> Modify(string studentId, Student student)
        {
            Student studentData = DBContext.Student.Find(studentId);

            if(student.StudentName != null)
            {
                studentData.StudentName = student.StudentName;
            }

            if(student.StudentContact != null)
            {
                studentData.StudentContact = student.StudentContact;
            }

            
            DBContext.SaveChanges();

            Student student1 = DBContext.Student.Find(studentId);
            return student1;

        }
    }
}
