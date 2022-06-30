using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(20,"Vlad");
            ShowInformationPlayer ShowInformationPlayer = new ShowInformationPlayer();

            ShowInformationPlayer.ShowInformation(player.Age, player.Name);
        }
    }

    class ShowInformationPlayer
    {
       public void ShowInformation(int age,string name)
        {
            Console.WriteLine($"Этому персонажу {age} лет и его зовут {name}");
        }
    }

    class Player
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Player(int age, string name)
        {
            Name = name;
            Age = age;
        }
    }
}
