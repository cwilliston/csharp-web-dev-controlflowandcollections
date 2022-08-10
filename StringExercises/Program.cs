using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string greenEggs = "I would not, could not, in a box. I would not, could not with a fox.\r\nI will not eat them in a house. I will not eat them with a mouse.";
            string[] arrayName = greenEggs.Split('.');
            Console.WriteLine(string.Join("/", arrayName));
        }
    }
}
