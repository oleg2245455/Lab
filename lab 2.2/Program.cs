using System;

namespace lab_2._2
{
    public class Box
    {
        public uint x_pos { get; set; }
        public uint y_pos { get; set; }
        public uint width_pos { get; set; }
        public uint heigh_pos { get; set; }
        public string mass { get; set; }
        public char symb_drow { get; set; }

        private void Drow(int X, int Y, int Width, int Heigh, string Mass, char Symb, ref string Massage)
        {
            if ((Width >= 3) | (Heigh >= 3))
            {
                Console.SetCursorPosition(X + (Width - Massage.Length) / 2, Y + Heigh / 2);
            }
            Console.SetCursorPosition(X, Y);
            for (int ii = 0; ii <= Heigh - 1; ii++)
            {
                for (int jj = 0; jj <= Width - 1; jj++)
                {
                    if (ii % (Heigh - 1) == 0 || jj % (Width - 1) == 0)
                    {
                        Console.SetCursorPosition(X + jj, Y + ii);
                        Console.Write(Symb);
                    }
                }
                Massage = "Ok! squere = " + Heigh * Width;

            }
        }
        public void Drow()
        {
            if (mass == null) mass = "";
            if
                (((symb_drow.Equals('*')) | (symb_drow.Equals('+')) | (symb_drow.Equals('.'))) == false)
                symb_drow = '*';
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string mass_loc = mass;
            if ((width_pos > 0) | (heigh_pos > 0))
            {
                int new_index = mass_loc.Length;
                new_index = (int)Math.Min(width_pos - 2, new_index);
                if ((width_pos >= 3) | (heigh_pos >= 3))
                {
                    mass_loc = mass_loc.Substring(0, Math.Max(0, new_index));
                }
                else mass_loc = "";
                this.drow((int)x_pos, (int)y_pos, (int)width_pos, (int)heigh_pos, symb_drow, ref mass_loc);
                this.mass = mass_loc;
            }
            else
            {
                this.mass = "One point";
                Console.SetCursorPosition((int)x_pos, (int)y_pos);
                Console.Write(symb_drow);
            }
            Console.ResetColor();
        }

        private void drow(int x_pos, int y_pos, int width_pos, int heigh_pos, char symb_drow, ref string Massage)
        {

        }
    }
    


    class Program
    {
        static void Main(string[] args)
        {
               void Paint()
            {
                Box p1 = new Box();
                Console.WriteLine("Type position of the box , x = ");
                p1.x_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type position of the box , y = ");
                p1.y_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type position of the box , width = ");
                p1.width_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type position of the box , heigh = ");
                p1.heigh_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type one of chars :  *, +, . ");
                p1.symb_drow = char.Parse(Console.ReadLine());
                Console.WriteLine("Type massage : ");
                p1.mass = Console.ReadLine();
                Console.WriteLine("Drowing...");
                p1.Drow();
                Console.WriteLine();
                Console.WriteLine(p1.mass);
                Console.WriteLine("Press any key...");
                Console.ReadLine(); 
            }
        }
    }
}
