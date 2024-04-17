using System;

class Program
{
    static void Main(string[] args)
    {
        // Взвод
        var platoon = new Platoon();

        // Додавання військових
        platoon.AddSoldier(new Soldier("Soldat 1", "Inzhener", "Gvuntivka"));
        platoon.AddSoldier(new Officer("Ofitser 1", "Comandyr", "Pistolet"));
        platoon.AddSoldier(new Soldier("Soldat 2", "Medik", "Gvuntivka"));
        platoon.AddSoldier(new Officer("Ofitser 2", "Rozvidnyk", "Gvuntivka"));

        // Сортування за бойовою спеціальністю
        platoon.SortSpecialty();

        // Виведення 
        platoon.PrintSame("Gvuntivka");
    }
}
