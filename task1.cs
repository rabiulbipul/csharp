using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarSpeed
{
    public class CarSpeed
    {
        private float acceleration;
        private string engine_number;
        private bool start;

        public CarSpeed(float acceleration, string engine_number, bool start)
        {
            this.acceleration = acceleration;
            this.engine_number = engine_number;
            this.start = start;
        }

        public void start_car()
        {
            start = true;
            Console.WriteLine("Car Started Successfully.");
        }

        public void stop_car()
        {
            start = false;
            Console.WriteLine("Car Started Successfully.");
        }

        public void set_acceleration(float ac)
        {
            acceleration = ac;
            Console.WriteLine("car's acceleration is : " + acceleration);
        }

        public void set_engine_number(string en)
        {
            engine_number = en;
            Console.WriteLine("Engine number of a car set to " + engine_number);
        }

        public float get_velocity(float t)
        {
           float time = t;
           
           float velocity;
           
            if(start == true)
            {
               velocity =acceleration* time;
                return velocity;
            }
           else
            {
                Console.WriteLine("Start the car first then retrieve velocity after acceleration.");
                    velocity = 0;
                return velocity;
            }
            

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                
                //for 1st object 

                CarSpeed car1 = new CarSpeed(0,"",false);
                Console.WriteLine("Details For the car 1");
                Console.WriteLine("Enter the engine number : ");
                string en1 = Console.ReadLine();
               
                Console.WriteLine("Enter the acceleration : ");
                float a1 =Single.Parse(Console.ReadLine());
       
                Console.WriteLine("Enter the time : ");
                float t1=Single.Parse( Console.ReadLine());
                
               
                car1.set_engine_number(en1);
                car1.set_acceleration(a1);
                car1.start_car();
                Console.WriteLine("velocity of the car after "+t1+" seconds is "+car1.get_velocity(t1));
                car1.stop_car();
                Console.WriteLine();
                //for 2nd object

                CarSpeed car2 = new CarSpeed(0, "", false);
                Console.WriteLine("Details For the car 2");
                Console.WriteLine("Enter the engine number : ");
                string en2 = Console.ReadLine();

                Console.WriteLine("Enter the acceleration : ");
                float a2 = Single.Parse(Console.ReadLine());

                Console.WriteLine("Enter the time : ");
                float t2 = Single.Parse(Console.ReadLine());
                

                car2.set_engine_number(en2);
                car2.set_acceleration(a2);
                car2.start_car();
                Console.WriteLine("velocity of the car after " + t2 + " seconds is " + car2.get_velocity(t2));
                car2.stop_car();
                Console.WriteLine();

                //for 3rd object

                CarSpeed car3 = new CarSpeed(0, "", false);
                Console.WriteLine("Details For the car 3");
                Console.WriteLine("Enter the engine number : ");
                string en3 = Console.ReadLine();

                Console.WriteLine("Enter the acceleration : ");
                float a3 = Single.Parse(Console.ReadLine());

                Console.WriteLine("Enter the time : ");
                float t3 = Single.Parse(Console.ReadLine());


                car3.set_engine_number(en3);
                car3.set_acceleration(a3);
                car3.start_car();
                Console.WriteLine("velocity of the car after " + t3 + " seconds is " + car3.get_velocity(t3));
                car3.stop_car();

            }
        }
    }
}

