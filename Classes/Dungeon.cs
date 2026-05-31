using System;
using Classes;

namespace Classes
{
	public class Dungeon
	{
		// Массив комнат
		public Room[] Rooms { get; }

		// Конструктор по умолчанию
		public Dungeon()
		{
			// Размер массива от 3 до 5 (пусть будет 3)
			Rooms = new Room[3];
			// Инициализация элементов массива
			Rooms[0] = new Room(
				new Unit("Bounti hunter", 100f, 5, 15),
				new Weapon("Pistol", 10, 20)
			);
			Rooms[1] = new Room(
				new Unit("Engineer", 80f, 3, 12),
				new Weapon("Metal arm", 8, 16)
			);
			Rooms[2] = new Room(
				new Unit("Sassy gambler", 60f, 7, 18),
				new Weapon("Uzi", 12, 24)
			);
		}

		public void ShowRoomsInfo()
		{
			for (int i = 0; i < Rooms.Length; i++)
			{
				Console.WriteLine($"Room {i + 1}:");
				Console.WriteLine($"  Unit: {Rooms[i].Unit.Name}, Health: {Rooms[i].Unit.Health}, Damage: {Rooms[i].Unit.Damage.Min}-{Rooms[i].Unit.Damage.Max}, Armor: {Rooms[i].Unit.Armor}");
				Console.WriteLine($"  Weapon: {Rooms[i].Weapon.Name}, Damage: {Rooms[i].Weapon.DamageInterval.Min}-{Rooms[i].Weapon.DamageInterval.Max}");
			}
		}
	}
}
