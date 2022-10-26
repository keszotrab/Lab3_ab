using Lab3_ab.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3_ab.Controllers
{
    public class NewController : Controller
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact()
            {
                Date = DateTime.Now, Id = 1,Name = "Marcin", Surename="Marcinowski", Subject ="bambam",
                Message = "dawaj na solo", Email = "szalonymarcin@gmail.com"

            },
             new Contact()
            {
                 Date = DateTime.Now,
                 Id = 2,
                 Name = "Dawid",
                 Surename="Dawidowski",Subject ="cykcyk",
                 Message = "dawaj na duo",
                 Email = "dawidaition@gmail.com"

            },
              new Contact()
            {
                 Date = DateTime.Now,
                 Id = 3,
                 Name = "Piotr",
                 Surename="Piorowski",Subject ="wabawaba",
                 Message = "co sie dzieje",
                 Email = "realspiederman2137@gmail.com"


            }

        };
        public static int messageCounter = 4; //pamietac o zwiekszaniu

        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        







        [HttpGet]
        public void ContactForm()
        { 
            //tworzenie formularza
        }

        [HttpPost]
        public void ContactForm(Contact contact)
        {
            //walidacja i dodwaanie do kolekcji
        }

        [HttpPost]
        public void EditForm(int id)
        {
            //wyswietlanie formularza do edycji
            //
        }

        [HttpPost]
        public void EditForm(Contact contact)
        {
            //kod walidujacy 
            //nadpisanie
        }

        [HttpGet]
        public void Delete(int id)
        {
            //usuwanie x obiektu w liscie
        }
    }
}
