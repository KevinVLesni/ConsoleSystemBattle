using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSystemBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int playersHealth = 100;
            int playerDamage = 50;
            int enemyHealth = 100;
            int enemyDamage = 50;

            while (playersHealth > 0 && enemyHealth > 0)
            {
                playersHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playersHealth + " игрок");
                Console.WriteLine(enemyHealth + " враг");
            }

            if (playersHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья! Победила дружба!");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Победа игрока!");
            }
            else if (playersHealth <= 0)
            {
                Console.WriteLine("Победа врага!");
            }
            Console.ReadLine();
        }
    }
}
