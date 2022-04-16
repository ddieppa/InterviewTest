// See https://www.simplethread.com/c-closures-explained/ for more information

List<Func<string> > functions = new List<Func<string>>();
// Act
int j = 0;
for (int i = 0; i < 10; i++)
{
    functions.Add(() => i + " " + j);
    j++;
}

foreach (var function in functions)
{
    Console.WriteLine(function.Invoke());
}


