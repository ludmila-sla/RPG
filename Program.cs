using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 22, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");
            BlackWizard blackWizard = new BlackWizard("Topapa", 33, "Black Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "Ninja");

            Console.WriteLine(knight.Attack());
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine(blackWizard.Attack(2));
            Console.WriteLine(ninja.Attack());
        }
    }
}