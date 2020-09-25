using System;

class AtCoder{
	public static void Main(string[] args){
    string S = Console.ReadLine();
      
      if(!S.EndsWith("s")){
      Console.WriteLine(S+"s");
      }else{
      Console.WriteLine(S+"es");
      }
  }
}