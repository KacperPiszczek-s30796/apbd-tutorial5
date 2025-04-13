using Users.Api.Models;

namespace Users.Api.Data;

public static class AnimalRepository
{
    public static List<Animal> Animals =
    [
        new() { Id = 1, Name = "Animal1", Weight = 10, FurColor = "Red" },
        new() { Id = 2, Name = "Animal2", Weight = 12, FurColor = "Blue" },
        new() { Id = 3, Name = "Beast3", Weight = 15, FurColor = "Green" },
        new() { Id = 4, Name = "Critter4", Weight = 8, FurColor = "Yellow" },
        new() { Id = 5, Name = "Creature5", Weight = 20, FurColor = "Black" },
        new() { Id = 6, Name = "Mammal6", Weight = 25, FurColor = "White" },
        new() { Id = 7, Name = "Furball7", Weight = 5, FurColor = "Gray" },
        new() { Id = 8, Name = "Pawsy8", Weight = 18, FurColor = "Brown" },
        new() { Id = 9, Name = "Whiskers9", Weight = 13, FurColor = "Orange" },
        new() { Id = 10, Name = "Fluffy10", Weight = 9, FurColor = "Purple" }
    ];
}