using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers {
    class Calculator {

        public double Pi = 3.14;

        public double GenerateCircumference(double ray) {
            return 2.0 * Pi * ray;
        }

        public double Volume(double ray) {
            return 4.0 / 3.0 * Pi * Math.Pow(ray, 3.0);
        }

    }
}
