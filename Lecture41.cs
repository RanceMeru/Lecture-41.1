
using System;
class Lecture41
{
    static void Main(string[] args)
    {
       //this is calling the method DisplayMessage and running eerything in it
        DisplayMessage();
        Console.WriteLine("Test");
        //calling this method will need to have two integers
        //Add(5,10);
        int answer = Add(5,10);
        int secondAnswer = Add(answer,5);
        Console.WriteLine(secondAnswer);//answer is now 20 not 15
                Console.ReadLine();

        
    }
        public static void DisplayMessage()
    {   //can reuse this code by calling the method DisplayMessage
         Console.WriteLine("Hello, World!");

    }
//public static void Add(int a, int b)
    public static int Add(int number1, int number2)
    //having integers in the method will make it need to have them when called
    //void cannot return anything so it will need to be changed to return something
    {
        int answer = number1 + number2;
        //Console.WriteLine(answer);
        //now the user wants to return the answer, they want to do something with it 
        return answer;
    }


}
// See https://aka.ms/new-console-template for more information
//return types 
//what we need is the keyword and the return type for now use static afterwards
