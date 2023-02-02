// See https://aka.ms/new-console-template for more information


using Exercise_Inheritance.Problem_1;

TestProblem1();

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

