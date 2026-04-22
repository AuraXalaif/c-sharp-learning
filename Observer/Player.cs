using System;

namespace ClimateControl
{
    public class Player
    {
        public event EventHandler<DamageEventArgs>? Damaged;

        public string Name { get; }
        private int _hp;
        public int Hp
        {
            get => _hp;
            private set => _hp = Math.Max(0, value);
        }

        public Player(string name, int initialHp = 100)
        {
            Name = name;
            Hp = initialHp;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0) return;

            Hp -= amount;
            Damaged?.Invoke(this, new DamageEventArgs(amount, Hp));
        }
    }
}