using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Interface
{
    namespace Assignment2.Interfaces
    {
        public interface IMovable
        {
            string Move();
        }

        public class Car : IMovable
        {
            public string Move()
            {
                return "Car is moving";
            }
        }

        public class Bicycle : IMovable
        {
            public string Move()
            {
                return "Bicycle is moving";
            }
        }
    }

}
