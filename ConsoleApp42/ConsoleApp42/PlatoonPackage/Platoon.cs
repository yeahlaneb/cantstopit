using System;
using System.Collections.Generic;
using System.Linq;

// Клас для взводів
class Platoon
{
    private List<Military> soldiers;

    public Platoon()
    {
        soldiers = new List<Military>();
    }

    public void AddSoldier(Military soldier)
    {
        soldiers.Add(soldier);
    }

    // За бойовою спеціальністю
    public void SortSpecialty()
    {
        soldiers = soldiers.OrderBy(soldier => soldier.MilitarySpecialty).ToList();
    }

    // У яких однакова зброя
    public void PrintSame(string weaponType)
    {
        Console.WriteLine($"Viyskovi, yaki korustuutsa zbroeu typu {weaponType}:");
        foreach (var soldier in soldiers)
        {
            if (soldier.WeaponType == weaponType)
            {
                Console.WriteLine(soldier.Name);
            }
        }
    }
}
