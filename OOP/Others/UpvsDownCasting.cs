using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Others
{
    //(upcasting)Conversion from a derived class to a base class
    //(downcasting)conversion from a base class to derived class
    class UpvsDownCasting
    {
        void Method()
        {
            //Upcasting
            Circle circle = new Circle();
            Shape shape = circle;

            //Downcasting
            Circle anotherCircle = (Circle)shape;  //In run time shape is referring to circle so valid

            //Invalid because in rum time its is nor referring to circle
            //Car car = (Car)shape;  Throws an invalid  exception to prevent use as keyword
            
        }

    }
    class Shape
    {
        // some code
    }


    class Circle : Shape
    {
        //some code
    }

    class Car : Shape
    {
        //some code
    }
}
