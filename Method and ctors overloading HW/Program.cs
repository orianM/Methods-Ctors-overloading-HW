using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_and_ctors_overloading_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*Methods overloading is: giving one method a few different signatures, 
              meaning - each signature is of the same method but with different parameters.*/

            #endregion

            #region question 2

            /*Constructors overloading is: giving one constructor a few different signatures,
              meaning - each signature is of the same constructor but with different parameters.*/

            #endregion

            #region question 3

            /*It isn't possible to overload a function to get the same arguments but with different names to each argument.
              Because you can't overload a function with the same parameters twice.*/

            #endregion

            #region question 4

            /*It isn't possible to overload a function to get the same parameters but return a different value type.
              Because the complier doesn't know which one of the overloaded functions to call to.*/

            #endregion

            #region question 5

            /*Ctor overloading can be useful when we want to give a few different options to create an instance,
              meaning - if we want to allow to create an instance with 2 values, 3 values or 4 values, 
              we would need to overload the constructor to allow each and every one.*/

            #endregion

            #region question 6

            /*examples of overloading from system: 1.Console.WriteLine()
                                                   2.new DateTime
                                                   3.Console.Write()*/

            #endregion

            #region question 8

            Computer instance1 = new Computer();
            instance1.TurnOff();
            SmartComp instance2 = new SmartComp();
            instance2.TurnOff();
            /*The SmartComp inherited the abilities of computer, but the SmartComp has another ability that the computer doesn't,
              that is why each instance has a different amount of overloads.*/

            #endregion
        }
    }

    #region question 7

    public class DigitalClock
    {
        public int second;
        public int minute;
        public int hour;
        public int temperature;

        public DigitalClock(int hour, int minute, int second)
        {
            this.second = second;
            this.minute = minute;
            this.hour = hour;
            this.temperature = temperature;
        }

        public DigitalClock(int hour, int minute, int second, int temperature) : this(second, minute, hour)
        {
            this.temperature = temperature;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{hour}:{minute}");
        }

        public void PrintDetails(int second)
        {
            Console.WriteLine($"{hour}:{minute}:{second}");
        }

        public void PrintDetails(int second, int temperature)
        {
            Console.WriteLine($"{hour}:{minute}:{second} temperature: {temperature}");
        }
    }

    #endregion

    #region question 8

    class Computer
    {
        public string[] allOpenFiles;
        public bool isOn;

        public Computer()
        {

        }

        public Computer(string[] allOpenFiles)
        {
            isOn = true;
            this.allOpenFiles = allOpenFiles;
        }

        public void TurnOff()
        {
            allOpenFiles = null;
            isOn = false;
        }

        public void TurnOff(bool ForceOff)
        {
            if (allOpenFiles == null)
            {
                isOn = false;
            }
            else
            {
                Console.WriteLine("Are you sure? Y/N");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    TurnOff();
                }
                
            }
        }
    }

    class SmartComp : Computer
    {
        public string[] filesInCache;

        public void TurnOff(bool forceOff, bool saveToCache)
        {
            if (forceOff)
            {
                if (allOpenFiles == null)
                    TurnOff();
                else
                {
                    if (saveToCache)
                    {
                        filesInCache = allOpenFiles;
                        TurnOff();
                    }
                }
            }
            else
            {
                if (saveToCache)
                {
                    filesInCache = allOpenFiles;
                    TurnOff();
                }
            }
        }
    }

    #endregion
}
