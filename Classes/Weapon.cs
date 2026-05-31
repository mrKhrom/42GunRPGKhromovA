namespace WeaponClasses
{
    public class Weapon
    {
        // Имя оружия, только для чтения
        public string Name { get; }
        // Минимальный урон, приватный сеттер
        public int MinDamage { get; private set; }
        // Максимальный урон, приватный сеттер
        public int MaxDamage { get; private set; }
        // Прочность, только для чтения
        public float Durability { get; }

        // Конструктор с одним строковым аргументом
        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
        }

        // Конструктор с тремя аргументами вызывает конструктор с одним аргументом через this и метод SetDamageParams
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        // Метод для установки параметров урона
        private void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage < 1)
            {
                MinDamage = 1;
                Console.WriteLine($"Минимальный урон был меньше 1. Принудительно установлен в 1 для оружия {Name}.");
            }
            else
            {
                MinDamage = minDamage;
            }

            if (maxDamage <= 1)
            {
                MaxDamage = 10;
            }
            else
            {
                MaxDamage = maxDamage;
            }
            if (MinDamage > MaxDamage)
            {
                // Если минимальный урон больше максимального, меняем их местами
                int temp = MinDamage;
                MinDamage = MaxDamage;
                MaxDamage = temp;
            }
            Console.WriteLine($"Weapon: {Name}, Min Damage: {MinDamage}, Max Damage: {MaxDamage}");
        }

        public int GetDamage()
        {
            return (MinDamage + MaxDamage) / 2;
        }
    }
}