using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        string lowers="abcdefghijklmnopqrstuvwxyz";
        string uppers=lowers.ToUpper();
        string digits="1234567890";
        string spacials="!@#$%^&*()";

        bool upper=false;
        bool lower=false;
        bool digit=false;
        bool spacial=false;
        // Console.WriteLine(lowers.ToUpper());
        string input=Console.ReadLine();
        int score=0;
        
        
        
        for(int j=0;j<input.Length;j++){// for loops to checks lower and upper cases;
           char curr=input[j];
          for(int i=0;i<lowers.Length;i++){
            if(curr==lowers[i])lower=true;
            if (curr==uppers[i])upper=true;
            
          }
          for(int i=0;i<digits.Length;i++){
            if(curr==digits[i])digit=true;
            if(curr==spacials[i])spacial=true;
        }
        
        }

        // Console.WriteLine(upper);
        // Console.WriteLine(lower);
        //end of lower and upper checks;
        if (lower)score++;
        if(upper)score++;
        if(digit)score++;
        if(input.Length>7)score++;
        if(spacial)score++;
        Console.WriteLine(score);
        switch(score){
          case 5:
          case 4:
            Console.WriteLine("extremely strong");
            break;
          case 3:
            Console.WriteLine("strong");
            break;
          case 2:
            Console.WriteLine("medium");
            break;
          case 1:
            Console.WriteLine("weak");
            break;
          default:
            Console.WriteLine("none");
            break;
        }
    }
  }
}
