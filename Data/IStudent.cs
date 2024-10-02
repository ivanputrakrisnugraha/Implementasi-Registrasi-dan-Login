using System;
using SampleSecureWeb.Models;

namespace _72220556sampleWebApp.Data;

public interface IStudent
{
    IEnumerable<Student> GetStudents();

    Student GetStudent(String nim);
    Student AddStudent(String student);
    Student UpdateStudent(Student Student);
    void DeleteStudent(String nim);
}