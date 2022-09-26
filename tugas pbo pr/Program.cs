using ProcessorClass;
using System.Diagnostics;

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        System.Console.WriteLine("Laptop " + merk + " dengan tipe " + tipe + " menyala");
    }

    public void LaptopDimatikan()
    {
        System.Console.WriteLine("Laptop " + merk + " dengan tipe " + tipe + " mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}

class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }

    public void BermainGame()
    {
        System.Console.WriteLine("Laptop " + merk + " dengan tipe " + tipe + " sedang memainkan game");
    }
}


class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}


class Vga
{
    public string merk;

}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class AMD : Vga
{
    public AMD()
    {
        merk = "AMD";
    }
}

class Processor
{
    public string merk;
    public string tipe;
}

namespace ProcessorClass
{
    class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core i7";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "RAYZEN";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        Laptop laptop2 = new IdeaPad();
        Predator predator = new Predator();


        //Soal No. 1
        Console.WriteLine("Soal No. 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //Soal No. 2
        Console.WriteLine("\nSoal No. 2");
        laptop1.Ngoding();

        //Soal No. 3
        Console.WriteLine("\nSoal No. 3");
        Vga vga1 = new Nvidia();
        Processor processor1 = new CoreI5();
        Console.WriteLine("Spesifikasi Laptop 1 \n" + "Merk VGA: " + vga1 + "\nMerk Processor: " + processor1.merk + "\nTipe Processor: " + processor1.tipe);

        //Soal No. 4
        Console.WriteLine("\nSoal No. 4");
        predator.BermainGame();

        //Soal No. 5
        Console.WriteLine("\nSoal No. 5");
        ACER acer = new Predator();
        acer.BermainGame();
    }
}
