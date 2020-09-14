using System;

class MainClass {
  public static void Main (string[] args) {
  Console.Write("DIgiteo primeiro número >> ");
  int num1 = int.Parse(Console.ReadLine());
   Console.Write("DIgiteo segundo número >> ");
  int num2 = int.Parse(Console.ReadLine());
  Console.WriteLine("Seu número multiplicado foi:"+Multiplica( num1, num2));
  }
  public static int Multiplica(int num1, int num2){
    return num1*num2;

  }
}