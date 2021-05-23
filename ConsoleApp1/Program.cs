using System;

namespace ConsoleApp1
{
    enum ComputerTypes
    {
        Desktop = 0,
        Laptop = 1,
        Server = 2,
    }
    struct Computer
    {
        public ComputerTypes comp;
        public int CPU;
        public float HGz;
        public int memory;
        public int HDD;
        public Computer(ComputerTypes comp)
        {
            this.comp = comp;
            switch ((int)comp)
            {
                case 0:
                    { CPU = 4; HGz = 2.5f; memory = 6; HDD = 500; break; }
                case 1:
                    { CPU = 2; HGz = 1.7f; memory = 4; HDD = 250; break; }
                case 2:
                    { CPU = 8; HGz = 3f; memory = 16; HDD = 2000; break; }

                default:
                    { Console.WriteLine("Error"); CPU = 0; HGz = 0; memory = 0; HDD = 0; break; }

            }


        }
        public void Show()
        {
            Console.WriteLine("Type:{0}, CPU :{1}, HGz:{2}, memory:{3}, HDD : {4}", comp, CPU, HGz, memory, HDD);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer[][] computers = new Computer[4][];

            computers[0] = new Computer[5];
            computers[1] = new Computer[3];
            computers[2] = new Computer[5];
            computers[3] = new Computer[4];

            computers[0][0] = new Computer { comp = ComputerTypes.Desktop, CPU = 4, HGz = 2.5f, memory = 6, HDD = 500 };
            computers[1][0] = new Computer { comp = ComputerTypes.Laptop, CPU = 2, HGz = 1.7f, memory = 4, HDD = 250 };
            computers[2][0] = new Computer { comp = ComputerTypes.Server, CPU = 8, HGz = 3f, memory = 16, HDD = 2000 };

            int computerNumber = 0;
            for (int i = 0; i < 2; i++)
            {
                computers[0][computerNumber] = new Computer(ComputerTypes.Desktop);
                computerNumber++;
            }
            for (int i = 0; i < 1; i++)
            {
                computers[0][computerNumber] = new Computer(ComputerTypes.Laptop);
                computerNumber++;
            }
            for (int i = 0; i < 1; i++)
            {
                computers[0][computerNumber] = new Computer(ComputerTypes.Server);
                computerNumber++;
            }
            for (int i = 0; i < 3; i++)
            {
                computers[1][computerNumber] = new Computer(ComputerTypes.Laptop);
                computerNumber++;
            }
            for (int i = 0; i < 3; i++)
            {
                computers[2][computerNumber] = new Computer(ComputerTypes.Desktop);
                computerNumber++;
            }
            for (int i = 0; i < 2; i++)
            {
                computers[2][computerNumber] = new Computer(ComputerTypes.Laptop);
                computerNumber++;
            }
            for (int i = 0; i < 2; i++)
            {
                computers[2][computerNumber] = new Computer(ComputerTypes.Server);
                computerNumber++;
            }

            for (int i = 0; i < computers.Length; i++)
                for (int j = 0; j < computers[i].Length; j++)
                {
                    Console.Write("computers {0}, Computer {1}:", i + 1, j + 1);
                    computers[i][j].Show();
                }
            int countDesktop = 0;
            int countLaptop = 0;
            int countServer = 0;
            int countComputer = 0;
            for (int i = 0; i < computers.Length; i++)
                for (int j = 0; j < computers[i].Length; j++)
                {
                    countComputer++;
                    if ((int)computers[i][j].comp == 0)
                        countDesktop++;
                    else if ((int)computers[i][j].comp == 1)
                        countLaptop++;
                    else if ((int)computers[i][j].comp == 2)
                        countServer++;
                }

            Console.WriteLine("Всего компьютеров " + countComputer + "\nИз них:");
            Console.WriteLine("Desktops: " + countDesktop);
            Console.WriteLine("Laptops: " + countLaptop);
            Console.WriteLine("Servers: " + countServer);


            int maxHddIndex1 = 0;
            int maxHddIndex2 = 0;
            int maxHdd = 0;
            for (int i = 0; i < computers.Length; i++)
                for (int j = 0; j < computers[i].Length; j++)
                {
                    if (computers[maxHddIndex1][maxHddIndex2].HDD < computers[i][j].HDD)
                    { maxHddIndex1 = i; maxHddIndex2 = j; maxHdd = computers[i][j].HDD; }
                }
            Console.WriteLine("Максимальный объем: " + maxHdd);
            Console.WriteLine("Располженные:");
            for (int i = 0; i < computers.Length; i++)
                for (int j = 0; j < computers[i].Length; j++)
                {
                    if (computers[maxHddIndex1][maxHddIndex2].HDD == computers[i][j].HDD)
                        Console.WriteLine("computers {0}, Computer{1}", i + 1, j + 1);
                }
            int minLowProdIndex1 = 0;
            int minLowProdIndex2 = 0;
            int lowCpu = 0;
            int lowMemory = 0;

            for (int i = 0; i < computers.Length; i++)
                for (int j = 0; j < computers[i].Length; j++)
                {
                    if ((computers[minLowProdIndex1][minLowProdIndex2].CPU > computers[i][j].CPU) && (computers[minLowProdIndex1][minLowProdIndex2].memory > computers[i][j].memory))
                    {
                        minLowProdIndex1 = i;
                        minLowProdIndex2 = j;
                        lowCpu = computers[i][j].CPU;
                        lowMemory = computers[i][j].memory;
                    }
                    Console.WriteLine("Минимальная продуктивность:CPU={0};Memory={1} ", lowCpu, lowMemory);
                    Console.WriteLine("Располженные:");
                    for (int b = 0; i < computers.Length; b++)
                        for (int c = 0; j < computers[b].Length; c++)
                        {
                            if ((computers[minLowProdIndex1][minLowProdIndex2].CPU == computers[b][c].CPU) &&
                            (computers[minLowProdIndex1][minLowProdIndex2].memory == computers[b][c].memory))
                                Console.WriteLine("computers{0}, Computer{1}", b + 1, c + 1);
                        }
                    Console.WriteLine("Desktops memory upgrade to 8");
                    for (int b = 0; i < computers.Length; b++)
                        for (int c = 0; j < computers[b].Length; c++)
                        {
                            if ((int)computers[i][j].comp == 0)
                                computers[b][c].memory = 8;
                        }
                    for (int b = 0; i < computers.Length; b++)
                        for (int c = 0; j < computers[b].Length; c++)
                        {
                            Console.Write("Department {0},Computer{1}:", i + 1, j + 1);
                            computers[b][c].Show();
                        }

                    
                }
            Console.ReadKey();
        }
    }


}    

