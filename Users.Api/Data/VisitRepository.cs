using Users.Api.Models;

namespace Users.Api.Data;

public static class VisitRepository
{
    public static List<Visit> Visits =
    [
        new() { DateOfVisit = new DateTime(2026, 1, 10), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 1), Description = "some description", Price = 10 },
        new() { DateOfVisit = new DateTime(2026, 1, 10), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 1), Description = "Annual checkup", Price = 10 },
new() { DateOfVisit = new DateTime(2026, 2, 5), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 2), Description = "Vaccination", Price = 15 },
new() { DateOfVisit = new DateTime(2026, 3, 12), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 1), Description = "Follow-up visit", Price = 12 },
new() { DateOfVisit = new DateTime(2026, 4, 20), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 3), Description = "Minor surgery", Price = 50 },
new() { DateOfVisit = new DateTime(2026, 5, 18), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 4), Description = "Grooming", Price = 20 },
new() { DateOfVisit = new DateTime(2026, 6, 2), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 5), Description = "Dental cleaning", Price = 25 },
new() { DateOfVisit = new DateTime(2026, 7, 9), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 6), Description = "Injury treatment", Price = 30 },
new() { DateOfVisit = new DateTime(2026, 8, 11), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 7), Description = "Eye check", Price = 18 },
new() { DateOfVisit = new DateTime(2026, 9, 22), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 8), Description = "Ear infection", Price = 22 },
new() { DateOfVisit = new DateTime(2026, 10, 1), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 9), Description = "Vaccination", Price = 15 },
new() { DateOfVisit = new DateTime(2026, 11, 5), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 10), Description = "Checkup and bath", Price = 28 },
new() { DateOfVisit = new DateTime(2026, 12, 8), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 2), Description = "Allergy treatment", Price = 35 },
new() { DateOfVisit = new DateTime(2026, 12, 20), Animal = AnimalRepository.Animals.FirstOrDefault(a => a.Id == 5), Description = "Routine exam", Price = 14 }
    ];
}