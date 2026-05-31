namespace UnitClasses
{
    public class Unit
    {
        // Имя юнита, только для чтения
        public string Name { get; }
        // Урон, только для чтения
        public int Damage { get; }
        // Приватное поле здоровья
        private float _health;
        // Свойство здоровья, только для чтения
        public float Health => _health;
        // Броня, только для чтения
        public float Armor { get; }

        // Конструктор без аргументов вызывает конструктор с аргументом (имя)
        public Unit() : this("Unknown Unit")
        {
        }

        // Конструктор с одним строковым аргументом (имя)
        public Unit(string name) : this(name, 100f)
        {
        }

        // Конструктор с аргументами для имени и здоровья
        public Unit(string name, float health)
        {
            Name = name;
            Damage = 5;
            _health = health;
            Armor = 0.6f;
        }

        public float GetRealHealth()
        {
            return _health * (1 + Armor);
        }
        public bool SetDamage(float value)
        {
            _health = _health - value * Armor;

            if (_health <= 0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}