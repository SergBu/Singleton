// See https://aka.ms/new-console-template for more information
using Singleton;

var instance1 = Singleton.Singleton.GetInstance();
var instance2 = Singleton.Singleton.GetInstance();

if (instance1.Equals(instance2))
{
    Console.WriteLine("один экземпляр");
}
else
{
    Console.WriteLine("разные экземпляры");
}

Console.WriteLine(instance1.GetHashCode());
Console.WriteLine(instance2.GetHashCode());

Console.WriteLine(instance1.GetType());
