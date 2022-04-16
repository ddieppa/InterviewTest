// See https://aka.ms/new-console-template for more information

using System.Text;

var sb = new StringBuilder();
var sbCopy = sb;
sb.Append("Hello World!");
sb = null;

Console.WriteLine(sbCopy.ToString());