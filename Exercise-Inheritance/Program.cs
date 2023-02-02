// See https://aka.ms/new-console-template for more information


using Exercise_Inheritance.Problem_1;
using Exercise_Inheritance.Problem_2;
using Exercise_Inheritance.Problem_3;

TestProblem3();

static void TestProblem1()
{
    try
    {
        Person p1 = new Person("Le Nguyen Hoang Long", 22);
        Console.WriteLine(p1);
        Child s1 = new Child("Le Nguyen Hoang Ngan", 16);
        Console.WriteLine(s1);
    }catch(ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }

}

static void TestProblem2()
{
    Lizard pet1 = new Lizard("Desert");
    Snake pet2 = new Snake("Jin");
    Gorilla pet3 = new Gorilla("King Kong");
    Bear pet4 = new Bear("Dragon");
    Console.WriteLine(pet1);
    Console.WriteLine(pet2);
    Console.WriteLine(pet3);
    Console.WriteLine(pet4);
}

static void TestProblem3()
{
    MuseElf player1 = new MuseElf("Nhat",11);
    DarkWizard player2 = new DarkWizard("Long",22);
    SoulMaster player3 = new SoulMaster("Triet", 33);
    DarkKnight player4 = new DarkKnight("Hoang", 44);
    BladeKnight player5 = new BladeKnight("Phuoc", 55);
    Console.WriteLine(player1);
    Console.WriteLine(player2);
    Console.WriteLine(player3);
    Console.WriteLine(player4);
    Console.WriteLine(player5);
}
