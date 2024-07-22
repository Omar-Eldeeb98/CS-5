using CS_5.ICloneable_Interface;
using CS_5.Interfaces;
using System;
using System.Text;

namespace CS_5
{
    internal class Program
    {
        #region interface EX 01
        //public static void print10NumbersFromSeries(ISeries series)
        //{
        //    if (series is not null)
        //    {
        //        for(int i = 0; i<10; i++)
        //        {
        //            Console.Write(series.Current + " " );
        //            series.getNext();
        //        }
        //        series.reset(); 
        //    }
        //}

        #endregion

        static void Main(string[] args)
        {
            #region Interface

            /*=====================[NOTES:]===============================*/
            // - u can not create object from interface.
            //  - u can create a reference from interface.
            //   - reference can refer to an object from class or struct that implement interface.

            /*IMyType myType;*/  // valid
                                 //myType.id = 10;  // invalid
                                 //myType.myFunc();  // invalid


            //MyType myType1 = new MyType();
            //myType1.id = 10;
            //myType1.myFunc(100);
            ///* myType1.print(); */ // invalid
            //Console.WriteLine("-------------------------------");
            //IMyType myType = new MyType(); // this is Ref from interface refer to object from class that implement interface.

            //myType.id = 20;
            //myType.myFunc(500);
            //myType.print(); // default implemented method.


            #endregion

            #region Interface EX 01

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //print10NumbersFromSeries(seriesByTwo);   // output :  0 2 4 6 8 10 12 14 16 18
            //Console.WriteLine("\n");

            //SeriesByThree seriesByThree = new SeriesByThree();  
            //print10NumbersFromSeries(seriesByThree);  // output : 0 3 6 9 12 15 18 21 24 27



            #endregion


            #region Interface EX 02 

            //Car car = new Car();
            //car.backward();  //output:  car move backward on ground

            //Console.WriteLine("\n");

            ////Airplane airplane = new Airplane();

            //IGround plan1 = new Airplane();
            //plan1.backward();     

            //IFlay plan2 = new Airplane();  
            //plan2.backward();

            #endregion



            #region shallow copy & deep copy

            #region (1) array of value type

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[3]; // {0 ,0 ,  0}

            //Console.WriteLine(arr1.GetHashCode()); // 54267293
            //Console.WriteLine(arr2.GetHashCode()); // 18643596

            #region shallow copy, happen in [stack]

            //Console.WriteLine("\n");

            //arr2 = arr1;
            //// shallow copy , because it happen at stack.
            //// arr1 , arr2 refer to the same object.

            //Console.WriteLine(arr1.GetHashCode()); // 54267293
            //Console.WriteLine(arr2.GetHashCode()); // 54267293

            //Console.WriteLine("\n");

            //Console.WriteLine(arr2[0]); // 1
            //Console.WriteLine(arr1[0]); // 1

            //Console.WriteLine("\n");

            //arr2[0] = 100; 
            //Console.WriteLine(arr2[0]); // 100
            //Console.WriteLine(arr1[0]); // 100 

            #endregion

            #region deep Copy, hapen in [heap]

            //arr2 = (int[]) arr1.Clone();
            //// clone() --> create (deep copy)
            //// create new object 
            //// that object will be the same [object state] means --> (DATA) of [caller] --> in this ex [arr1]

            //Console.WriteLine(arr1.GetHashCode()); // 54267293
            //Console.WriteLine(arr2.GetHashCode()); // 18643596

            //Console.WriteLine("\n");

            //Console.WriteLine(arr1[0]); // 1
            //Console.WriteLine(arr2[0]); // 1

            //Console.WriteLine("\n");

            //arr2[1] = 77; // arr[1] will be not affected by arr2[1].

            //Console.WriteLine(arr1[1]); // 2
            //Console.WriteLine(arr2[1]); // 77

            #endregion


            #endregion


            #region (2) array of reference type


            //string[] names1 = { "omar" };
            //string[] names2 = new string[1];   // {null} 
            //Console.WriteLine(names1.GetHashCode()); // 54267293
            //Console.WriteLine(names2.GetHashCode()); // 18643596
            //Console.WriteLine("\n");

            #region shallow copy (array of string)
            //Console.WriteLine(names1.GetHashCode()); // 54267293
            //Console.WriteLine(names2.GetHashCode()); // 18643596


            //Console.WriteLine("\n");

            //names2 = names1;  // shallow copy

            //Console.WriteLine(names1.GetHashCode()); // 54267293
            //Console.WriteLine(names2.GetHashCode()); // 54267293

            //Console.WriteLine("\n");

            //Console.WriteLine(names1[0]); // omar
            //Console.WriteLine(names2[0]); // omar


            //Console.WriteLine("\n");

            //names2[0] = "mona";


            //Console.WriteLine(names1[0]); // mona
            //Console.WriteLine(names2[0]); // mona

            #endregion


            #region deep copy (array of string)

            //names2 = (string[]) names1.Clone(); // dep copy 

            //Console.WriteLine("after making deep copy.");

            //Console.WriteLine(names1.GetHashCode()); // 54267293
            //Console.WriteLine(names2.GetHashCode()); // 33574638

            //Console.WriteLine("\n");

            //Console.WriteLine(names1[0]); // omar
            //Console.WriteLine(names2[0]); // omar

            //Console.WriteLine("\n");

            //names1[0] = "ahmed";

            //Console.WriteLine(names1[0]); // ahmed
            //Console.WriteLine(names2[0]); // omar


            #endregion


            //StringBuilder[] name1 = new StringBuilder[1];
            //StringBuilder[] name2 = new StringBuilder[1];

            //name1[0] = new StringBuilder("Omar");

            //Console.WriteLine(name1.GetHashCode()); // 54267293
            //Console.WriteLine(name2.GetHashCode()); // 18643596

            //Console.WriteLine("\n");


            #region shallow copy (array of StringBuilder)

            //name2 = name1; // shallow copy.

            //Console.WriteLine(name1.GetHashCode()); // 54267293
            //Console.WriteLine(name2.GetHashCode()); // 54267293


            //Console.WriteLine("\n");


            //Console.WriteLine(name1[0]);  // Omar
            //Console.WriteLine(name2[0]);  // Omar


            //Console.WriteLine("\n");

            //name1[0].Append(" Eldeeb");

            //Console.WriteLine(name1[0]); // Omar Eldeeb
            //Console.WriteLine(name2[0]); // Omar Eldeeb

            #endregion



            #region deep copy (array of StringBuilder)

            //name2 = (StringBuilder[]) name1.Clone(); // dep copy 

            //Console.WriteLine("after deep copy");

            //Console.WriteLine(name1.GetHashCode()); // 54267293
            //Console.WriteLine(name2.GetHashCode()); // 33574638 

            //Console.WriteLine("\n");

            //Console.WriteLine(name1[0]);  // Omar
            //Console.WriteLine(name2[0]); // Omar


            //Console.WriteLine("\n");

            //name2[0].Append(" Jika");

            //Console.WriteLine(name1[0]); // Omar Jika
            //Console.WriteLine(name2[0]); // Omar Jika




            #endregion





            #endregion


            #endregion



            //Employee e1 = new Employee() { id = 10 , name = "Ahmed", salary = 9000};
            //Employee e2 = new Employee() { id = 20, name = "Omar", salary = 5000 };


            //Console.WriteLine(e1.GetHashCode()); // 54267293
            //Console.WriteLine(e2.GetHashCode()); // 18643596

            //Console.WriteLine("\n");

            //Console.WriteLine(e1.ToString()); // id:10 , name:Ahmed , salary:$9,000.00
            //Console.WriteLine(e2.ToString()); // id:20 , name:Omar , salary:$5,000.00

            //Console.WriteLine("\n");

            #region shallow copy in user defined reference data type
            //e2 = e1; // shallow copy

            //Console.WriteLine("after shallow copy.");

            //Console.WriteLine(e1.GetHashCode()); // 54267293 
            //Console.WriteLine(e2.GetHashCode()); // 54267293 

            //Console.WriteLine(e1.ToString()); // id:10 , name:Ahmed , salary:9,000.00
            //Console.WriteLine(e2.ToString()); // id:10 , name:Ahmed , salary:9,000.00

            //Console.WriteLine("\n");


            //e1.id = 69;
            //e1.name = "John";
            //e1.salary = 30000;

            //Console.WriteLine("after update e1.");
            //Console.WriteLine(e1.ToString()); // id:69 , name:John , salary:$30,000.00
            //Console.WriteLine(e2.ToString()); // id:69 , name:John , salary:$30,000.00

            //Console.WriteLine("\n");

            #endregion


            #region deep copy in user defined reference data type [Icloneable] built-in interface

            //e2 = (Employee) e1.Clone();
            //Console.WriteLine("after deep copy");

            //Console.WriteLine(e1.GetHashCode()); // 54267293
            //Console.WriteLine(e2.GetHashCode()); // 33574638

            //Console.WriteLine("\n");

            //Console.WriteLine(e1.ToString());
            //Console.WriteLine(e2.ToString());

            //Console.WriteLine("\n");

            //Console.WriteLine("after update e2");

            //e2.name = "ayaaaaa";

            //Console.WriteLine(e1.ToString()); // id:10 , name:Ahmed , salary:$9,000.00
            //Console.WriteLine(e2.ToString()); // id:10 , name:ayaaaaa , salary:$9,000.00




            #endregion

            #region  [ICompareable] built-in Interface
            //int[] numbers = { 5, 7, 8, 1, 2, 3, 4, 6, 9, 10 };
            //Array.Sort(numbers);

            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //Employee[] employee = new Employee[3]
            //{ // properties initializer.

            //    new Employee(){id = 1, name = "Omar" , salary = 10000 },
            //    new Employee(){id = 2, name = "Mona" , salary = 7500 },
            //    new Employee(){id = 3, name = "Ahmed" , salary = 5000 }
            //};

            /* ============================== OR =================================== */

            //employee[0] = new Employee() {id = 1 , name = "Omar" , salary = 10000 };
            //employee[1] = new Employee() {id = 2 , name = "Mona" , salary = 7500 };
            //employee[2] = new Employee() {id = 3 , name = "Ahmed", salary = 5000 };


            //Array.Sort(employee);
            //foreach(Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //}


            //Console.WriteLine("\n");

            #endregion



            #region [IComparer] built-in Interface

            //Employee[] employee = new Employee[3]
            //{ // properties initializer.
            //    new Employee(){id = 3, name = "Ahmed", salary = 5000 },
            //    new Employee(){id = 1, name = "Omar", salary = 10000 },
            //    new Employee(){id = 2, name = "Mona", salary = 7500 }
               
            //};


            //Array.Sort(employee , new EmployeeIdComparer());
            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //}
     
            //Console.WriteLine("\n");

            #endregion




        }
    }
}
