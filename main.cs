using System;
using showit;
using add;
public class main{
public static void Main(string[] args){

    int choice;

    do
    {
        Console.Clear();
        Console.WriteLine("Hey, welcome to kids Mathmatic Quesitons automation!");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("press 1 for Addition");
        Console.WriteLine("press 2 for Subtraction");
        Console.WriteLine("press 3 for Multiply");
        Console.WriteLine("press 4 for division");
        Console.WriteLine(System.Environment.NewLine); 

        Console.WriteLine("what's your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());
        
        if(choice==1)
        {
         Console.Clear();
         Console.WriteLine("Addtion, good choice! How many questions you want: ");
         int i = Convert.ToInt32(Console.ReadLine());
         System.Threading.Thread.Sleep(1000);
         Console.Clear();
            
            show q = new show();
            int j=0;
            while(j<i)
            {
                q.RandomAddNumbers();
                q.showaddquestion();
                j=j+1;
            }
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Please any key to exit");
            Console.ReadKey();
            break;

        }
        else if(choice==2) {
            Console.Clear();
            Console.WriteLine("Subtraction, good choice! How many questions you want: ");
            int i =Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            show q = new show();
            int j=0;
            while(j<i)
            {
                q.RandomSubNumbers();
                q.showSubquestion();
                j=j+1;
            }
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Please any key to exit");
            Console.ReadKey();
            break;
        }


        else if (choice==3) {
            Console.Clear();
            Console.WriteLine("Multiply, good choice! How many questions you want: ");
            int i =Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            show q = new show();
            int j=0;
            while(j<i)
            {
                q.RandomMulNumbers();
                q.showMulquestion();
                j=j+1;
            }
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Please any key to exit");
            Console.ReadKey();
            break;
        }




        else if (choice==4){
            Console.Clear();
            Console.WriteLine("Division, good choice! How many questions you want: ");
            int i =Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            show q = new show();
            int j=0;
            while(j<i)
            {
                q.RandomDivNumbers();
                q.showDivquestion();
                j=j+1;
            }
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Please any key to exit");
            Console.ReadKey();
            break;
        }



        else {
            Console.Clear();
            Console.WriteLine("Wrong input!");
            System.Threading.Thread.Sleep(1000);
            }
    
    } while(choice>1 || choice<5);
    
    
    
    }

}


