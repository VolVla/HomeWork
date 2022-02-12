using System;

namespace BattleRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool isExit = false;
            int healthHero = 120;
            int healthEnemy = 200;
            int pointCurse = 0;
            int magicPointVoodoo = 0;
            int pointsFireEffect = 0;
            string userInput;
            bool helpOfSpirits = true;

            Console.WriteLine("Вы открыли дверь и встретили босса, он настроен враждебно, чтобы его победить используйте свои способности\nСражение начинается");

            while (isExit == false)
            {
                const int minimumVoodooPoint = 4;
                const int deathOfHero = 13;
                int enemyDamage = rand.Next(30, 45);
                const int minimumFirePoints = 3;
                int damegeFromSecondSpell = rand.Next(30, 40);
                int damegeFromFirstSpell = rand.Next(20, 30);

                Console.WriteLine("\nУ вас " + healthHero + " здоровья и " + pointCurse + " очков проклятья при достижение " + deathOfHero + " очков вы умрете.,\nУ босса " + healthEnemy + " здоровья "+magicPointVoodoo +" очков проклятье вуду и "+pointsFireEffect + " очков подгорания.\n\n Вы можете применить способности. \n 1 - Атака Огненым шаром \n 2 - Попросить духов о помощи (можно использовать один раз), игнорирует одну атаку противника,\n и востанавливает не много здоровья \n 3 - Проклятье куклы вуды (востанавливает не много здоровья на кладывает на противника одно проклятье вуду.)\n 4 - Проткнуть куклу вуду(наносит сильный урон при этом тратит "+ minimumVoodooPoint + " очка проклятья вуду.)");
                userInput = Console.ReadLine();

                if (pointCurse == deathOfHero)
                {
                 Console.WriteLine("Вы не успели победить противника.На вас наложилось не изличимое проклятие уродства.\n Вы посмотрели в зеркало и не переживаете этого, и умираете от сердечного приступа.");
                 healthHero -= healthHero;
                }

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Вы атаковали fireball  и нанесли " + damegeFromFirstSpell + " Враг получил " + pointsFireEffect + " point эффекта подгорания. ");
                        healthEnemy -= damegeFromFirstSpell;
                        ++pointsFireEffect;
                        Console.WriteLine("Враг вас атаковал нас и нанес " + enemyDamage + " урона и наложили 1 очко проклятья.");
                        healthHero -= enemyDamage;
                        ++pointCurse;

                        if (pointsFireEffect == minimumFirePoints)
                        {
                         int damageFire = rand.Next(30, 40);
                         const int fireEffect = 0;

                         healthEnemy -= damageFire;
                         healthHero += damageFire;
                         pointsFireEffect = fireEffect;
                         Console.WriteLine("\nВраг подгорел и получил " + damageFire + " урона и запах жареным бекконом это вам востановило " + damageFire + " здоровья.");
                        }
                        break;
                    case "2":

                        if (helpOfSpirits == true)
                        {
                         Console.WriteLine("Враг попытался нанести вам " + enemyDamage + " урон, но вы призвали духов и они защитили вас и не много подлечили на " + enemyDamage + " здоровья.");
                         healthHero += enemyDamage;
                         helpOfSpirits = false;
                        }
                        else if (helpOfSpirits == false)
                        {
                         Console.WriteLine("Вы уже использовали эту споспобность.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Вы посылаете на босса проклятье и востанавливаете " + damegeFromSecondSpell);
                        healthHero += damegeFromSecondSpell;
                        ++magicPointVoodoo;
                        Console.WriteLine("Враг вас атаковал нас и нанес " + enemyDamage + " урона и наложили 1 очко проклятья.");
                        healthHero -= enemyDamage;
                        ++pointCurse;
                        break;
                    case "4":

                        if (minimumVoodooPoint <= magicPointVoodoo)
                        {
                         int damegeFromThirdSpell = rand.Next(70, 85);
                         
                         Console.WriteLine("\nВы использовали куклу вуду, врагу очень больно вы нанесли " + damegeFromThirdSpell + " урона");
                         healthEnemy -= damegeFromThirdSpell;
                         Console.WriteLine("Враг вас атаковал нас и нанес " + enemyDamage + " урона и наложили 1 очко проклятья.");
                         healthHero -= enemyDamage;
                         ++pointCurse;
                         magicPointVoodoo -= minimumFirePoints;
                        }
                        else
                        {
                         Console.WriteLine("\nВы не можете использовать куклу вуду у вас не достаточно " + (minimumVoodooPoint - magicPointVoodoo) + " очков магии вуду");
                        }
                        break;
                }
                const int deathPerson = 0;

                if (healthHero <= deathPerson && healthEnemy <= deathPerson)
                {
                 Console.WriteLine("\nПоздравляю вы убили друг друга. Вы не победили и не проиграли. Досвидания ");
                 isExit = true;
                }
                else if (healthHero <= deathPerson)
                {
                 Console.WriteLine("\nВас убили.Босс на смехается над вашим трупом.");
                 isExit = true;
                }
                else if (healthEnemy <= deathPerson)
                {
                 Console.WriteLine("\nВы убили босса.Вы победили герой.");
                 isExit = true;
                }
            }
        }
    }
}
