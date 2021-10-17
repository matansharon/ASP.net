using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program ...
      Author: ...
      */



      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "Matan story";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("please enter a name");
      string main_char=Console.ReadLine();
      Console.WriteLine("please enter 3 adjectives");
      string first_adjective=Console.ReadLine();
      string second_adjective=Console.ReadLine();
      string third_adjective=Console.ReadLine();
      Console.WriteLine("please enter a verb");
      string verb= Console.ReadLine();
      Console.WriteLine("please enter 2 nouns");
      string noun1=Console.ReadLine();
      string noun2=Console.ReadLine();
      string []arr=new string[7];
      string []inputs=new string[]{"animal","food","fruit","superhero","country","desert","year"};
      for(int i =0;i<7;i++){
          if (i==0){
            Console.WriteLine("please enter an animal");
            arr[0]=Console.ReadLine();
          }
          else{
            Console.WriteLine($"please enter a {inputs[i]}");
            arr[i]=Console.ReadLine();
          }
      }
      for(int i=0;i<arr.Length;i++){
        Console.WriteLine(arr[i]);
      }


      // The template for the story:
      Console.WriteLine("Mad libs has started");
      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:

    }
  }
}
