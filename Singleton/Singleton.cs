using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //синглетон - класс, который позволяет чтобы один экземпляр был создан.
    //во время исполнения программы только один экземпляр класса существует для всех пользователей
    // Declaring a static class documents your intent for that class to be a collection of static functionality, and anyone adding instance members will get a compilation error.
    //A non-static class with static members usually indicates that the class is designed to be instantiated at some point.Static methods of these classes usually do one of two things:
    //Provide a factory method for creating an instance of that type;
    //   Provide helper functionality that does not require an instance of the type;
    //   Also, as mentioned already, extension methods can only be declared on a static class.

    //When you are providing utility functions and all your methods are static, I recommend you use static methods in a static class.
    //When you want to provide utility methods that just deal with your instance, I recommend you use static methods in a non-static class. For example:

    //var myClass = MyClass.Create();
    //var myClass = MyClass.Parse("serialized.MyClass");
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object _instanceLock = new object();

        public static Singleton GetInstance()
        {
            lock (_instanceLock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        //public override bool Equals(object obj)
        //{
        //    return base.GetHashCode() == obj.GetHashCode();
        //}
        public override int GetHashCode()
        {
            Random rnd = new Random();
            return rnd.Next();
        }

        public override string ToString()
        {
            return base.GetHashCode().ToString();
        }

    }
}
