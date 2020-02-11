using System;
using System.Collections.Generic;
using System.Text;

namespace RobosvsDinos
{
    class Battlefield
    {
        Fleet fleet;
        Herd herd;
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        //public void DinosTurn(Dinosaur dinosaur)
        //{
        //    DisplayAttackOptions("dinos");
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    dinosaur.Attack(fleet.robots[choice]);
        //    if(fleet.robots[choice].health <= 0)
        //    {
        //        fleet.robots.Remove(fleet.robots[choice]);
        //    }
        //}
        //public void RoboTurn(Robot robot)
        //{
        //    DisplayAttackOptions("robos");
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    robot.Attack(herd.dinosaurs[choice]);
        //    if(herd.dinosaurs[choice].health <= 0)
        //    {
        //        herd.dinosaurs.Remove(herd.dinosaurs[choice]);
        //    }
        //}

        public void WarriorTurn(Warrior warrior, string forWho, List<Warrior> warriorsBeingAttacked)
        {
            DisplayAttackOptions(forWho);
            int choice = Convert.ToInt32(Console.ReadLine());
            warrior.Attack(warriorsBeingAttacked[choice]);
            if(warriorsBeingAttacked[choice].health <= 0)
            {
                warriorsBeingAttacked.Remove(warriorsBeingAttacked[choice]);
            }
            //if(forWho == "dinos")
            //{
            //    warrior.Attack(fleet.robots[choice]);
            //}
            //else
            //{
            //    warrior.Attack(herd.dinosaurs[choice]);
            //}

        }
        public void DisplayAttackOptions(string forWho)
        {
            Console.WriteLine("Please choose to attack!");
            if(forWho == "dinos")
            {
                for(int i = 0; i < fleet.robots.Count; i++)
                {
                    Console.WriteLine(i + ") " + fleet.robots[i].name);
                }
            }
            else
            {
                for (int i = 0; i < herd.dinosaurs.Count; i++)
                {
                    Console.WriteLine(i + ") " + herd.dinosaurs[i].name);
                }
            }
        }
        public void SimulateBattle()
        {
            // have each team attack eachother back and forth until one team dies
            bool dinosTurn = true;
            while (herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                if(dinosTurn == true)
                {
                    //DinosTurn(herd.dinosaurs[0]);
                    WarriorTurn(herd.dinosaurs[0], "dinos", fleet.robots);
                    dinosTurn = false;
                }
                else
                {
                    //RoboTurn(fleet.robots[0]);
                    WarriorTurn(fleet.robots[0], "robos", herd.dinosaurs);
                    dinosTurn = true;
                }
            }
            DisplayWinner();
        }

        public void DisplayWinner()
        {
            if(herd.dinosaurs.Count <= 0)
            {
                Console.WriteLine("Dinos Won!");
            }
            else
            {
                Console.WriteLine("Robos Won!");
            }
        }
    }
}
