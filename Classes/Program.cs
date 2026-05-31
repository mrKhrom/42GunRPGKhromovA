using System;
using UnitClasses;
using WeaponClasses;

namespace ProgramNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("Sword", 10, 20);
            Console.WriteLine($"Weapon: {weapon.Name}");
            Console.WriteLine($"Min Damage: {weapon.MinDamage}");
            Console.WriteLine($"Max Damage: {weapon.MaxDamage}");
            Console.WriteLine($"Damage: {weapon.GetDamage()}");

            Unit unit = new Unit("Warrior", 100f);
            Console.WriteLine($"Name: {unit.Name}");
            Console.WriteLine($"Health: {unit.Health}");
            Console.WriteLine($"Damage: {unit.Damage}");
            Console.WriteLine($"Armor: {unit.Armor}");

            float playerHealth = unit.GetRealHealth();
            Console.WriteLine($"Player Health: {playerHealth}");

            bool isDead = unit.SetDamage(30f);
            if (isDead)
            {
                Console.WriteLine("The " + unit.Name + " is dead.");
            }
            else
            {
                Console.WriteLine($"Health after damage: {unit.Health}");
            }
        }
    }
}