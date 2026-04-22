using System;

namespace ClimateControl
{
    public class SoundSystem
    {
        public void Subscribe(Player player) => player.Damaged += OnPlayerDamaged;
        public void Unsubscribe(Player player) => player.Damaged -= OnPlayerDamaged;

        private void OnPlayerDamaged(object? sender, DamageEventArgs e)
        {
            Console.WriteLine("SoundSystem: Play damage sound");
            if (e.CurrentHp <= 20)
            {
                Console.WriteLine("SoundSystem: Play critical health sound");
            }
        }
    }
}