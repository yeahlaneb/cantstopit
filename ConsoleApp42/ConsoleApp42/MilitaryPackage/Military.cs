using System;

// клас Військовий
class Military
{
    public string Name { get; }
    public string MilitarySpecialty { get; }
    public string WeaponType { get; }

    public Military(string name, string militarySpecialty, string weaponType)
    {
        Name = name;
        MilitarySpecialty = militarySpecialty;
        WeaponType = weaponType;
    }
}

// Ієрархія
class Soldier : Military
{
    public Soldier(string name, string militarySpecialty, string weaponType) : base(name, militarySpecialty, weaponType) { }
}

class Officer : Military
{
    public Officer(string name, string militarySpecialty, string weaponType) : base(name, militarySpecialty, weaponType) { }
}
