using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab_1.Models;
using System.Net;
using System.Xml.Linq;

namespace Lab_1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> lst = new List<Student>();
        public StudentController()
        {
            //tao ds sinh vien co 4 du lieu mau
            lst = new List<Student>()
            {
                new Student()
                {
                    Id = 101,
                    Name = "Hai Nam",
                    Branch = Branch.IT,
                    Gender = Gender.Male,
                    IsRegular = true,
                    Address = "A1-2018",
                    Email = "nam@g.com",
                    Marks = 8.8
                },
                new Student()
                {
                    Id = 102,
                    Name = "Minh Tú",
                    Branch = Branch.BE,
                    Gender = Gender.Female,
                    IsRegular = true,
                    Address = "A1-2019",
                    Email = "tu@gmail.com",
                    Marks = 7

                },
                new Student()
                {
                    Id = 103,
                    Name = "Hoàng Phong",
                    Branch = Branch.CE,
                    Gender = Gender.Male,
                    IsRegular = false,
                    Address = "A1-2020",
                    Email = "phong@gmail.com",
                    Marks = 10
                },

                new Student()
                {
                    Id = 104,
                    Name = "Xuân Mai",
                    Branch = Branch.EE,
                    Gender = Gender.Female,
                    IsRegular = false,
                    Address = "A1-2021",
                    Email = "mai@g.com",
                    Marks = 2.4
                }
            };
        }

        //[Route("Admin/Student/List")]
        public IActionResult Index()
        {
            return View(lst);
        }

        //[Route("Admin/Student/List")]
        [HttpGet]
        public IActionResult Create ()
        {
            //Lấy danh sách các giá trị Gender để hiển thị radio button trên form
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            //Lấy ds các giá trị Branch để hiển thị select-option trên form
            //để hiện thị select-option trên View cần dùng List<SelectListItem>
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT", Value = "1" },
                new SelectListItem { Text = "BE", Value= "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" }
            };
            return View();
        }

        //[Route("Admin/Student/List")]
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if(ModelState.IsValid)
            {
                s.Id = lst.Last<Student>().Id + 1;
                lst.Add(s);
                return View("Index", lst);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT", Value = "1" },
                new SelectListItem { Text = "BE", Value = "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" }
            };
            return View();
            
        }
    }
}
