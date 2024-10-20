// See https://aka.ms/new-console-template for more information



string Trafficsignal = Console.ReadLine();

   if (Trafficsignal == "red" || Trafficsignal == "yellow" || Trafficsignal == "green")

     {
    

          switch (Trafficsignal)
          {
            case "red":
            Console.WriteLine("stop");
              break; 

           case "yellow":
            Console.WriteLine("Get ready to stop ");
            break; 

              case "green":
              Console.WriteLine("go");
              break;   

              default:
              Console.WriteLine("Invaid traffic light color ");
               break;

   }   


   }

