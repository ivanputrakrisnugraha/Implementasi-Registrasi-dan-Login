using Microsoft.AspNetCore.Mvc;
using _72220556sampleWebApp.Models;
using SampleSecureWeb.Models;
using _72220556sampleWebApp.Data; 

namespace _72220556sampleWebApp.Controllers;

public class StudentController : Controller
{
    private readonly StudentData _studentData; 

    public StudentController(StudentData studentData)
    {
        _studentData = studentData;
    }

    public IActionResult Index()
    {
        var students = _studentData.GetStudents(); 
        return View(students);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        try
        {
            if (ModelState.IsValid) 
            {
                _studentData.AddStudent(student);
                return RedirectToAction("Index");
            }
        }
        catch (System.Exception ex)
        {
            ViewBag.Error = ex.Message; 
        }
        return View(student); 
    }

    public IActionResult Edit(int id)
    {
        var student = _studentData.GetStudents();
        if (student == null)
        {
            return NotFound();
        }
        return View(student);
    }

    [HttpPost]
    public IActionResult Edit(Student student)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _studentData.UpdateStudent(student);
                return RedirectToAction("Index");
            }
        }
        catch (System.Exception ex)
        {
            ViewBag.Error = ex.Message;
        }
        return View(student);
    }

    public IActionResult Delete(int id)
    {
        var student = _studentData.GetStudents();
        if (student == null)
        {
            return NotFound();
        }
        return View(student);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        try
        {
            _studentData.DeleteStudents();
            return RedirectToAction("Index");
        }
        catch (System.Exception ex)
        {
            ViewBag.Error = ex.Message;
        }
        return RedirectToAction("Delete", new { id });
    }
}
