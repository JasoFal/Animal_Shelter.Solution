using Microsoft.AspNetCore.Mvc;
using Animal_Shelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Animal_Shelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index(string sortRule)
    {
      if (sortRule == "DOA")
      {
        List<Animal> model = _db.Animals.OrderBy(a=>a.DOA).ToList();
        return View(model);
      }
      else if (sortRule == "Type")
      {
        List<Animal> model = _db.Animals.OrderBy(a=>a.Type).ToList();
        return View(model);
      }
      else if (sortRule == "Breed")
      {
        List<Animal> model = _db.Animals.OrderBy(a=>a.Breed).ToList();
        return View(model);
      }
      else
      {
        List<Animal> model = _db.Animals.ToList();
        return View(model);
      }
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }
  }
}