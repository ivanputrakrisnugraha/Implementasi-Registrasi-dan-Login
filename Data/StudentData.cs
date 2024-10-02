using System;
using System.Security.Cryptography.X509Certificates;
using _72220556sampleWebApp.data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SampleSecureWeb.Models;

namespace _72220556sampleWebApp.Data;

public class StudentData : IStudent
{
    private ApplicationDbContext _db;

    public Student AddStudent(string student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(string nim)
    {
        throw new NotImplementedException();
    }

    public Student GetStudent(string nim)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetStudents()
    {
        throw new NotImplementedException();
    }

    public Student UpdateStudent(Student Student)
    {
        throw new NotImplementedException();
    }

public StudentData(ApplicationDbContext db)
    {
        _db = db;
    }
 public Student AddStudent(Student student)
    {
        try{
            _db.Students.Add(student);
            _db.SaveChanges();
            return student;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
    }

    }

    internal string? GetStudentById(int id)
    {
        throw new NotImplementedException();
    }

    internal void DeleteStudents()
    {
        throw new NotImplementedException();
    }
}