using System;

namespace ClimateControl
{
    public class UIHealthBar
    {
        public void Subscribe(Player player) => player.Damaged += OnPlayerDamaged;
        public void Unsubscribe(Player player) => player.Damaged -= OnPlayerDamaged;

        private void OnPlayerDamaged(object? sender, DamageEventArgs e)
        {
            Console.WriteLine($"UIHealthBar: Player HP = {e.CurrentHp}");
        }
    }
}