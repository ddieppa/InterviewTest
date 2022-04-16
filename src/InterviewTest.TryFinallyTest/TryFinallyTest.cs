// See https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-finally for more information

var test = new Test();
test.PrintWithoutExceptions();
test.PrintAWithExceptions();
test.PrintWithExceptionWithinTheTry();


class Test
{
    public void PrintWithExceptionWithinTheTry()
    {
        int i = 123;
        string s = "Some string";
        object obj = s;

        this.A();
        try
        {
            i = (int)obj;
            this.B();
        }
        finally
        {
            this.C();
        }
        this.D();
    }

    public void PrintWithoutExceptions()
    {
        this.A();
        try
        {
            this.B();
        }
        finally
        {
            this.C();
        }
        this.D();
    }

    public void PrintAWithExceptions()
    {
        this.AWithException();
        try
        {
            this.B();
        }
        finally
        {
            this.C();
        }
        this.D();
    }

    public void A()
    {
        Console.WriteLine("A");
    }

    public void AWithException()
    {
        throw new System.Exception("A");
    }

    public void B()
    {
        //throw new NullReferenceException("B");
        Console.WriteLine("B");
    }

    public void C()
    {
        Console.WriteLine("C");
    }
    public void D()
    {
        Console.WriteLine("D");
    }

}

class A
{
    public void Print()
    {
        Console.WriteLine("A");
    }
}

class B
{
    public void Print()
    {
        Console.WriteLine("B");
    }
}

class C
{
    public void Print()
    {
        Console.WriteLine("C");
    }
}

class D
{
    public void Print()
    {
        Console.WriteLine("D");
    }
}

