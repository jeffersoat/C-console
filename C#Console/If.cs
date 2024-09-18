

class If
{

    public static void Numbers(int number)
     {
         if (number > 0)
     {
         Console.WriteLine("Your number is positive. ");
       }
        else if (number < 0)
       {
           Console.WriteLine("Your number is Negative. ");
      }
       else
     {
           Console.WriteLine("Your number is Zero. ");
     }
    }

    public static void Health(int health)
    {
        {
         if (health > 75)
     {
         Console.WriteLine("Your fine. ");
       }
       else if (health > 50)
       {
          Console.WriteLine("You need to heal. ");
         }
          else if (health > 0)
          {
            Console.WriteLine("please heal man. ");
          }
      else
     {
          Console.WriteLine("told you, you needed to heal. ");
     }
    }
    }
}