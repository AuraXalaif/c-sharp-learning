using System;
using System.Numerics;

namespace ClimateControl
{
    class Program
    {
        static void Main()
        {
            var player = new Player("Hero", initialHp: 100);

            var ui = new UIHealthBar();
            var sound = new SoundSystem();
            var achievements = new AchievementSystem();
            var logger = new GameLogger();

            // Подписываем системы
            ui.Subscribe(player);
            sound.Subscribe(player);
            achievements.Subscribe(player);
            logger.Subscribe(player);

            // Наносим урон последовательно
            int[] damages = { 10, 30, 15, 50, 5 };

            Console.WriteLine($"Starting HP = {player.Hp}\n");

            foreach (var d in damages)
            {
                Console.WriteLine($"\n-- Applying damage {d} --");
                player.TakeDamage(d);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
