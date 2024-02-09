using System;
using System.Threading;

class program
{
  static bool isInputOn = false;
  static bool shouldTrigger = false;
  
  static void Main(string[] args)
  {
    Thread InputThread = new Thread(CheckInput);
    Thread triggerThread = new Thread(CheckTimeandTrigger);
    
    inputThread.Start();
    triggerThread.Start();
    
    inputThread.Join();
    triggerThread.Join();
    
    Console.WriteLine("Script Completed.");
  }
  
  static void CheckInput()
  {
    // Simulate input state change (true for demonstration purposes)
    Thread.Sleep(2000);
    isInputOn = true;
    Console.WriteLine("Input is ON.");
  }
  
  static void CheckTimeAndTrigger()
  {
    while (true)
    {
      if (isInputOn)
      {
        Thread.Sleep(1000); //sleep for 1 sec
        if (isInputOn)
        {
          Thread.Sleep(4000); //sleep for 4 seconds
          shouldTrigger = true;
          Console.WriteLine("Triggered after 5 seconds.");
          break;
        }
      }
    }
  }
}
