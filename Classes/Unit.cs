namespace Classes
{
    public class Unit
    {
        public string Name { get; }
        public Interval Damage { get; }
        private float _health;
        public float Health => _health;
        public float Armor { get; }

        public Unit() : this("Unknown Unit", 100f, 0, 10) {}

        public Unit(string name) : this(name, 100f, 0, 10) {}

        public Unit(string name, float health) : this(name, health, 0, 10) {}

        public Unit(string name, float health, int minDamage, int maxDamage)
        {
            Name = name;
            Damage = new Interval(minDamage, maxDamage);
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