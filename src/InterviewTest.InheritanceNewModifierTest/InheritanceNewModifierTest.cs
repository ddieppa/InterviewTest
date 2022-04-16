// See https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-modifier for more information
TestBase test = new TestBase();
test.Print();

TestBase test1 = new Test1();
test1.Print();

TestBase test2 = new Test2();
test2.Print();

(test1 as TestBase).Print();
(test2 as Test1).Print();
(test2 as TestBase).Print();

class TestBase
{
    public virtual void  Print(){
        Console.WriteLine("Base");
    }
}

class Test1 : TestBase
{
    public override void Print(){
        Console.WriteLine("Test1");
    }
}

class Test2 : Test1
{
    public new void Print(){
        Console.WriteLine("Test2");
    }
}
