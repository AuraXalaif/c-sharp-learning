using System;

namespace ClimateControl
{
    public class GameLogger
    {
        public void Subscribe(Player player) => player.Damaged += OnPlayerDamaged;
        public void Unsubscribe(Player player) => player.Damaged -= OnPlayerDamaged;

        private void OnPlayerDamaged(object? sender, DamageEventArgs e)
        {
            Console.WriteLine($"GameLogger: Took {e.Damage} damage, HP now {e.CurrentHp}");
        }
    }
}