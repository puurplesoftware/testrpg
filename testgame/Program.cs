using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace testgame
{   
    public class Player
    {
        private int health;
        private int attack;
        private string attackType;
        private string name;
        private bool alive;
        private ArrayList inventory;
        public Player(int health, int attack, string name, bool alive)
        {
            this.health = health;
            this.attack = attack;
            this.name = name;
            this.alive = alive;
            this.inventory = new ArrayList();
        }

        public void setHealth(int health)
        {
            this.health = health;
        }
        public int getHealth()
        {
            return health;
        }
        public void setAttack(int attack)
        {
            this.attack = attack;
        }
        public int getAttack()
        {
            return attack;
        }

        public void setAttackType(string attackType)
        {
            this.attackType = attackType;
        }
        public string getAttackType()
        {
            return attackType;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setAlive(bool alive)
        {
            this.alive = alive;
        }
        public bool getAlive()
        {
            return alive;
        }

        public void addItemToInventory(Item item)
        {
            this.inventory.Add(item);
        }

        public ArrayList getInventory()
        {
            return inventory;
        }


        public void healthCheck()
        {
            if (getHealth() > 0)
            {
                Console.WriteLine("You are still alive.");
            }
            else if (getHealth() <= 0)
            {
                Console.WriteLine("You are dead.");
                setAlive(false);
            }
        }
    }

    public class Enemy
    {
        private int health;
        private int attack;
        private string attackType;
        private string name;
        private bool alive;
        private ArrayList inventory;

        public Enemy()
        {
            //this.inventory = new ArrayList();
        }
    }

    public class Item
    {
        private string name;

        public Item(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }

    public class Elf : Player
    {
        public Elf() : base(50, 10, "", true)
        {
             
        }
    }

    public class Human : Player
    {
        public Human() : base(55, 8, "", true)
        {

        }
    }

    public class Dwarf : Player
    {
        public Dwarf() : base(60, 6, "", true)
        {

        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Choose your race");
            Console.WriteLine("Type elf, human or dwarf");

            string userSelection;
            userSelection = Console.ReadLine();
            userSelection = userSelection.ToLower();
            Console.WriteLine("Please enter in your character name ");
            string playerName = Console.ReadLine();

            // creating player
            Player player = new Player(0, 0, "", true);

            if (userSelection == "elf")
            {
                player = new Elf();
                player.setName(playerName);
            }
            else if (userSelection.Equals("human"))
            {
                player = new Human();
                player.setName(playerName);
            }
            else if (userSelection.Equals("dwarf"))
            {
                player = new Dwarf();
                player.setName(playerName);
            }





            // Combat with first enemy
            //while ((enemyHealth > 0) && (playerOneHealth > 0))
            //{
            //    Console.WriteLine("Enemy atacks you.");
            //    playerOneHealth = Combat(playerOneHealth, enemyHealth, playerAlive);
            //    Console.WriteLine($"Player one health is at {playerOneHealth}.");
            //    playerOne.healthCheck(playerOneHealth);
            //    if (playerOneHealth <= 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("You attack the enemy.");
            //    enemyHealth = Combat(enemyHealth, playerOneAttack, enemyAlive);
            //    Console.WriteLine($"Enemy is health is at {enemyHealth}.");
            //    enemy.healthCheck(enemyHealth);
            //    if (enemyHealth <= 0)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine(playerHuman.getName() + " " + playerHuman.getHealth() + " " + playerHuman.getAttack());
            Console.WriteLine("Welcome, " + player.getName() + " " + player.GetType());

            






           
            Console.ReadLine();
            



        }
    }


}
