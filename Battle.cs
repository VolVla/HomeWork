using System;

namespace BattleRpg
{
    class Program
    {
        static void Main()
        {
            const string CommandAttackFireball = "1";
            const string CommandAttackSpirit = "2";
            const string CommandCurseEnemy = "3";
            const string CommandAttackCurse = "4";

            string userInput;
            Random random = new Random();
            bool singleHelpOfSpirits = true;
            int healthHero = 120;
            int healthEnemy = 200;
            int currentValueIsCurse = 0;
            int storageMagicPointVoodoo = 0;
            int pointsFireEffect = 0;
            int minimumEnemyDamage = 30;
            int minimumDamageSecondSpell = 30;
            int minimumDamageFirstSpell = 20;
            int minimumDamageThirdSpell = 70;
            int minimumDamageFire = 30;
            int maximumEnemyDamage = 45;
            int maximumDamageSecondSpell = 40;
            int maximumDamageFirstSpell = 30;
            int maximumDamageFire = 40;
            int maximumDamageThirdSpell = 85;
            int pointsPowerCurseOnHero = 1;
            int fireEffect = 0;
            int conditionApplicationMagicVoodooPoints = 4;
            int conditionApplicationFirePoints = 3;
            int pointsBeforeDeathfHero = 13;
            int pointsBeforeDeathPerson = 0;
            int enemyDamage = random.Next(minimumEnemyDamage, maximumEnemyDamage);
            int damegeFromSecondSpell = random.Next(minimumDamageSecondSpell, maximumDamageSecondSpell);
            int damegeFromFirstSpell = random.Next(minimumDamageFirstSpell, maximumDamageFirstSpell);
            int damageFire = random.Next(minimumDamageFire, maximumDamageFire);
            int damegeFromThirdSpell = random.Next(minimumDamageThirdSpell, maximumDamageThirdSpell);

            Console.WriteLine("Вы открыли дверь и встретили босса, он настроен враждебно, чтобы его победить используйте свои способности\nСражение начинается");

            while (healthHero >= pointsBeforeDeathPerson & healthEnemy >= pointsBeforeDeathPerson)
            {
                Console.WriteLine($"\nУ вас  {healthHero}  здоровья и  {currentValueIsCurse}  очков проклятья при достижение  {pointsBeforeDeathfHero}  очков вы умрете" +
                $".\nУ босса {healthEnemy}  здоровья  {storageMagicPointVoodoo} очков проклятье вуду и {pointsFireEffect} очков подгорания.\n\n Вы можете применить способности." +
                $" \n {CommandAttackFireball}- Атака Огненым шаром \n {CommandAttackSpirit} - Попросить духов о помощи (можно использовать один раз), игнорирует одну атаку противника," +
                $"\n и востанавливает не много здоровья \n {CommandCurseEnemy} - Проклятье куклы вуды (востанавливает не много здоровья на кладывает на противника одно проклятье вуду.)" +
                $"\n {CommandAttackCurse} - Проткнуть куклу вуду(наносит сильный урон при этом тратит " + conditionApplicationMagicVoodooPoints + " очка проклятья вуду.)");
                userInput = Console.ReadLine();

                if (currentValueIsCurse == pointsBeforeDeathfHero)
                {
                    Console.WriteLine("Вы не успели победить противника.На вас наложилось не изличимое проклятие уродства.\n Вы посмотрели в зеркало и не переживаете этого, и умираете от сердечного приступа.");
                    healthHero -= healthHero;
                }

                switch (userInput)
                {
                    case CommandAttackFireball:
                        Console.WriteLine("Вы атаковали fireball  и нанесли " + damegeFromFirstSpell + " Враг получил " + pointsFireEffect + " point эффекта подгорания. ");
                        healthEnemy -= damegeFromFirstSpell;
                        ++pointsFireEffect;
                        Console.WriteLine("Враг вас атаковал нас и нанес " + enemyDamage + " урона и наложили " + pointsPowerCurseOnHero + " очко проклятья.");
                        healthHero -= enemyDamage;
                        ++currentValueIsCurse;

                        if (pointsFireEffect == conditionApplicationFirePoints)
                        {
                            healthEnemy -= damageFire;
                            healthHero += damageFire;
                            pointsFireEffect = fireEffect;
                            Console.WriteLine("\nВраг подгорел и получил " + damageFire + " урона и запах жареным бекконом это вам востановило " + damageFire + " здоровья.");
                        }
                        break;
                    case CommandAttackSpirit:
                        if (singleHelpOfSpirits == true)
                        {
                            Console.WriteLine("Враг попытался нанести вам " + enemyDamage + " урон, но вы призвали духов и они защитили вас и не много подлечили на " + enemyDamage + " здоровья.");
                            healthHero += enemyDamage;
                            singleHelpOfSpirits = false;
                        }
                        else if (singleHelpOfSpirits == false)
                        {
                            Console.WriteLine("Вы уже использовали эту споспобность.");
                        }
                        break;
                    case CommandCurseEnemy:
                        Console.WriteLine("Вы посылаете на босса проклятье и востанавливаете " + damegeFromSecondSpell);
                        healthHero += damegeFromSecondSpell;
                        ++storageMagicPointVoodoo;
                        Console.WriteLine("Враг вас атаковал нас и нанес " + enemyDamage + " урона и наложили " + pointsPowerCurseOnHero + " очко проклятья.");
                        healthHero -= enemyDamage;
                        ++currentValueIsCurse;
                        break;
                    case CommandAttackCurse:

                        if (conditionApplicationMagicVoodooPoints <= storageMagicPointVoodoo)
                        {
                            Console.WriteLine("\nВы использовали куклу вуду, врагу очень больно вы нанесли " + damegeFromThirdSpell + " урона");
                            healthEnemy -= damegeFromThirdSpell;
                            Console.WriteLine("Враг вас атаковал нас и нанес " + enemyDamage + " урона и наложили " + pointsPowerCurseOnHero + " очко проклятья.");
                            healthHero -= enemyDamage;
                            ++currentValueIsCurse;
                            storageMagicPointVoodoo -= conditionApplicationMagicVoodooPoints;
                        }
                        else
                        {
                            Console.WriteLine("\nВы не можете использовать куклу вуду у вас не достаточно " + (conditionApplicationMagicVoodooPoints - storageMagicPointVoodoo) + " очков магии вуду");
                        }
                        break;
                }
            }

            if (healthHero <= pointsBeforeDeathPerson && healthEnemy <= pointsBeforeDeathPerson)
            {
                Console.WriteLine("\nПоздравляю вы убили друг друга. Вы не победили и не проиграли. Досвидания ");

            }
            else if (healthHero <= pointsBeforeDeathPerson)
            {
                Console.WriteLine("\nВас убили.Босс на смехается над вашим трупом.");

            }
            else if (healthEnemy <= pointsBeforeDeathPerson)
            {
                Console.WriteLine("\nВы убили босса.Вы победили герой.");
            }

            Console.ReadKey();
        }
    }
}
