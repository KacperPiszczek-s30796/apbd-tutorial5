using Microsoft.AspNetCore.Mvc;
using Users.Api.Data;
using Users.Api.Models;

namespace Users.Api.Controllers;

[ApiController]
[Route("animals")]
public class AnimalController: ControllerBase
{
    private readonly List<Animal> _animals = AnimalRepository.Animals;
    private readonly List<Visit> _visits = VisitRepository.Visits;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        return Ok(_animals.FirstOrDefault(a => a.Id == 1));
    }

    [HttpPost]
    public IActionResult Add([FromBody] Animal animal)
    {
        AnimalRepository.Animals.Add(animal);
        return Ok(animal + " has been created");
    }

    [HttpPut]
    public IActionResult Update([FromBody] Animal updatedAnimal)
    {
        var existingAnimal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == updatedAnimal.Id);

        if (existingAnimal == null)
        {
            return NotFound($"Animal with ID {updatedAnimal.Id} not found.");
        }

        existingAnimal.Name = updatedAnimal.Name;
        existingAnimal.Weight = updatedAnimal.Weight;
        existingAnimal.FurColor = updatedAnimal.FurColor;
        return Ok(updatedAnimal + " has been updated.");
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var existingAnimal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal == null)
        {
            return NotFound($"Animal with ID {id} not found.");
        }
        AnimalRepository.Animals.Remove(existingAnimal);
        return Ok(existingAnimal + "has been deleted.");
    }

    [HttpGet("{id:int}/visits")]
    public IActionResult GetAllAnimalsVisits(int id)
    {
        var existingAnimal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == id);
        List<Visit> animalsVisits = new List<Visit>();
        foreach (var visit in _visits)
        {
            if (visit.Animal == existingAnimal)animalsVisits.Add(visit);
        }
        return Ok(animalsVisits);
    }

    [HttpPost]
    public IActionResult AddVisit([FromBody] Visit visit)
    {
        _visits.Add(visit);
        return Ok(visit + " has been added.");
    }
}