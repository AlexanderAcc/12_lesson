using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_interface
{
    internal class Animal : IFly, ISwim // Реализация интерфейсов в классе
    {
        public string Fly() // метод для интерфейса IFly
        {
            return "can fly"; // Ответ метода
        }
        public string Swim() // метод для интерфейса ISwim
        {
            return "can swim"; // Ответ метода
        }
    }
}
