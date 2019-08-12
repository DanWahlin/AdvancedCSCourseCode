using System;
namespace Chapter4.Interfaces {
	public class CarTest {

        public static void Main() {
            Car myCar = new Car();
            Console.WriteLine("Starting myCar..");
            myCar.TurnLeft();
            myCar.TurnRight();
            myCar.GoStraight();
            myCar.GoStraight();
            myCar.GoBackwards();
            Console.WriteLine("");

            Console.WriteLine("Starting myCar2..");
            IDrive myCar2 = new Car();
            myCar2.TurnLeft();
            myCar2.TurnRight();

            Console.ReadLine();

        }

    }
}
