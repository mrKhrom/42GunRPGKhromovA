namespace Classes
{
    public class Weapon
    {        
        public string Name { get; }
        public Interval DamageInterval { get; private set; }
        public float Durability { get; }

        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            DamageInterval = new Interval(minDamage, maxDamage);
        }

        public double GetDamage()
        {
            return DamageInterval.Get;
        }
    }
}