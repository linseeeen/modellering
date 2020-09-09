using System;

namespace modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            football f1 = new football() {posX = 20, posY = 20};
            
            Player p1 = new Player();
            p1.name = "Billy";
            p1.age = 13;

            Audience a1 = new Audience();
            a1.size = 13000;
            a1.happy = 6;
        }
    }
}
