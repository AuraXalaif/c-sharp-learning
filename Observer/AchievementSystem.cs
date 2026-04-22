using System;

namespace ClimateControl
{
    public class AchievementSystem
    {
        private bool _halfHealthUnlocked = false;
        private bool _firstDeathUnlocked = false;

        public void Subscribe(Player player) => player.Damaged += OnPlayerDamaged;
        public void Unsubscribe(Player player) => player.Damaged -= OnPlayerDamaged;

        private void OnPlayerDamaged(object? sender, DamageEventArgs e)
        {
            if (!_halfHealthUnlocked && e.CurrentHp <= 50 && e.CurrentHp > 0)
            {
                _halfHealthUnlocked = true;
                Console.WriteLine("AchievementSystem: Achievement unlocked - Half Health");
            }

            if (!_firstDeathUnlocked && e.CurrentHp <= 0)
            {
                _firstDeathUnlocked = true;
                Console.WriteLine("AchievementSystem: Achievement unlocked - First Death");
            }
        }
    }
}