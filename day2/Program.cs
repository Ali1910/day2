using System;
using System.Runtime.CompilerServices;

namespace day2
{
    class progrm
    {
        class student
        {
            public int id;
            public int age;
        }
        static void Main()
        {
            #region value vs refernce datatype
            //// value 
            //int x1;// exception variable not used
            //int x = 5; // alocate at stack
            //int y=10;
            //x=9; 
            //y=11;
            //x=y;// exchange value
            //Console.WriteLine($"x= {x} , y={y}");
            //int z= new int();
            //Console.WriteLine(z);// will print 0 beacuse of new

            //ref 
            //student s;
            //s.id=5; // error unassinged datatype
            // solution ?
            //student s = new student();
            //Console.WriteLine($"s.id={s.id},s.age={s.age}");// will print 0 beacuse of new
            //s.id = 5;
            //s.age = 20;
            //student s1 = new student();
            //s1.id = 7;
            //s1.age = 21;
            //Console.WriteLine($"s.id={s.id},s.age={s.age}");// will print 5 ,20 
            //Console.WriteLine($"s.id={s1.id},s.age={s1.age}");// will print 7 ,21 

            //s = s1; // exchange reference 
            //Console.WriteLine($"s.id={s.id},s.age={s.age}");// will print 7 ,21 
            //Console.WriteLine($"s.id={s1.id},s.age={s1.age}");// will print 7 ,21


            //s1.age = 27;
            //Console.WriteLine($"s.id={s.id},s.age={s.age}");// will print 7 ,27 
            //Console.WriteLine($"s.id={s1.id},s.age={s1.age}");// will print 8,27
            //s.age = 70;
            //Console.WriteLine($"s.id={s.id},s.age={s.age}");// will print 7 ,70 
            //Console.WriteLine($"s.id={s1.id},s.age={s1.age}");// will print 8,70

            #endregion
            #region control statemant
            ////condational

            ////if :check one condition based on it i will take action 
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //if(num > 0 )// logical expersion
            //{// block of code need {} if its more than one line
            //    Console.WriteLine($"{num} is positive");
            //}

            ////if else check two conditions based on they i will take actions
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)// logical expersion
            //{// block of code need {} if its more than one line
            //    Console.WriteLine($"{num} is positive");
            //}
            //else 
            //{
            //    Console.WriteLine($"{num} is not positive");
            //}

            ////if else if .... else more than two conditions
            //Console.WriteLine("enter your budget");
            //int budget =int.Parse(Console.ReadLine());
            //if (budget >= 1000 && budget < 1200)
            //{
            //    Console.WriteLine("breakfat");
            //}
            //else if (budget >= 1200 && budget < 1400)
            //{
            //    Console.WriteLine("breakfast+dinner");
            //}
            //else if (budget >= 1400 && budget < 1600) 
            //{
            //    Console.WriteLine("breakfast+dinner+lunch");
            //}
            //else if (budget >= 1600)
            //{
            //    Console.WriteLine("master room");
            //}
            //else 
            //{
            //    Console.WriteLine("invalied budget"); 
            //}

            //// switch  used more than condition with equality
            //switch (budget)
            //{
            //    case 1000: // to cases have the same body
            //    case 1100:
            //        Console.WriteLine("breakfast");
            //        break;
            //    case 1200:
            //        Console.WriteLine("breakfast+ dinner");
            //        break;
            //    case 1400:
            //        Console.WriteLine("breakfast+dinner+lunch");
            //        break;
            //        default: Console.WriteLine("invalid");
            //        break;
            //}


            ////loop

            ////while myabe executed many times or 0 
            //int sum = 0;
            //while (sum < 100) 
            //{
            //    Console.Clear();
            //    Console.WriteLine("enter sum");
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;
            //    Console.WriteLine(sum);
            //} 


            ////dowhile  i take data before check and i need at least one execution
            //String phone = null;
            //do
            //{
            //    Console.WriteLine("enter phone num");
            //    phone = Console.ReadLine();
            //}
            //while (phone.Length != 11);

            ////for  : i know the start and the end

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 0;
            //for(; i < 10; ) {
            //    Console.WriteLine( i);
            //    i++;
            //}

            // nested loop

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"i={i}");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine($"i={i} , j={j}");

            //    }
            //}

            //foreach
            #endregion

            #region one dimential array 
            // how to write an arrray
            //int[] x = new int[5];
            //Console.WriteLine(x[0]); // will print 0 due to new 
            //int[] y = new int[] { 1,2,3,4,5,6};
            //Console.WriteLine(x[0]);// will print 1
            //int[] z = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(x[4]);// will print 5

            // how to make user put data in the array

            //Console.WriteLine("number of students");
            //int numOfstudents = int.Parse(Console.ReadLine());
            //int[] gardes = new int[numOfstudents];
            //for (int i = 0; i < numOfstudents; i++)
            //{
            //    Console.WriteLine($"enter garde{i + 1}");
            //    gardes[i] = int.Parse(Console.ReadLine());


            //}
            //Array.Sort( gardes );// sort ascending
            //Array.Reverse( gardes );// reverse array


            //int sum = 0;
            //for (int i = 0; i < gardes.Length; i++)
            //{
            //    Console.WriteLine($"garde of student{i + 1}= {gardes[i]}");
            //    sum += gardes[i];
            //}
            //Console.WriteLine($"sum= {sum}");

            #endregion
            #region multi dimential array
            //// how to write multi dimential array
            //int[,] x = new int[3, 4];
            //int[,] z = { { 1, 2, 3, 4 }, { 3, 3, 2, 4 }, { 4, 5, 3, 4 } };
            //int[,] y = new int[3,4] { { 1,2,3, 4 }, { 3,3,2,4},{ 4,5,3,4} };
            //Console.WriteLine(y[2,3]);// will print 4
            //Console.WriteLine(y[0,2]);// will print 3
            //Console.WriteLine(y[1, 2]);// will print 2
            //Console.WriteLine(y[2, 1]);// will print 5

            //enter data to ,ulti dimentsion array
            Console.WriteLine("enter number of students");
            int numOfStudents =int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of subjects");
            int numOfSubjects = int.Parse(Console.ReadLine());
            int[,] grades = new int[numOfStudents, numOfSubjects];
            for (int i = 0; i < numOfStudents; i++)
            {

                for (int j = 0; j < grades.GetLength(1); j++) 
                {
                    Console.WriteLine($"enter garde{j+1} for student{i+1}");
                    grades[i,j]= int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0;i < grades.GetLength(0); i++) 
            {
                for(int j = 0;j < grades.GetLength(1); j++)
                {
                    Console.WriteLine($"student {i + 1} garde in subject {j + 1}= {grades[i, j]}");
                }
                Console.WriteLine("---------------------------");
            }
            
            #endregion
        }
    }
}
