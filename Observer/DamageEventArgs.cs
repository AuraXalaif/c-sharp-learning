using System;

namespace ClimateControl
{
    public class DamageEventArgs : EventArgs
    {
        public int Damage { get; }
        public int CurrentHp { get; }

        public DamageEventArgs(int damage, int currentHp)
        {
            Damage = damage;
            CurrentHp = currentHp;
        }
    }
}