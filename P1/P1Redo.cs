using System;

namespace P1Redo;
public class P1Redo
{
    public static void Main(string[] args)
    {
        GridFleaRedo test = new GridFleaRedo(15);
        Console.WriteLine("Initiale state & info");
        Console.WriteLine("Active: "+test.DisplayActiveState());
        Console.WriteLine("Permanent state: "+test.DisplayPermanentState());
        Console.WriteLine("Reward: " + test.DisplayReward());
        Console.WriteLine("Value: " + test.Value());
        test.Move(5);
        Console.WriteLine("State & info after first move"); 
        Console.WriteLine("Active: " + test.DisplayActiveState());
        Console.WriteLine("Permanent state: " + test.DisplayPermanentState());
        Console.WriteLine("Reward: " + test.DisplayReward());
        Console.WriteLine("Value: " + test.Value());

        //test.Move(10);
        test.Move(5);
        test.Move(3);
        test.Move(1);
        test.Move(1);
        test.Move(0);
     // test.Move(1);
     // test.Move(1);
        //test.Move(4);
        //test.Move(4);
        // test.Move(4);
        //test.Move(4);
        Console.WriteLine("State & info after first move");
        Console.WriteLine("Active: " + test.DisplayActiveState());
        Console.WriteLine("Permanent state: " + test.DisplayPermanentState());
        Console.WriteLine("Reward: " + test.DisplayReward());
        Console.WriteLine("Value: " + test.Value());
        test.Reset();
        
        Console.WriteLine("State & info after first move");
        Console.WriteLine("Active: " + test.DisplayActiveState());
        Console.WriteLine("Permanent state: " + test.DisplayPermanentState());
        Console.WriteLine("Reward: " + test.DisplayReward());
        Console.WriteLine("Value: " + test.Value());
        /*
        //  test.Move(20);
        //  test.Move(30);
        //  test.Move(10);
        //  test.Move(20);
        //  test.Move(30);
        //est.Move(10);
        //test.Move(20);
        // test.Move(30);
        Console.WriteLine("State & info after first move");
        Console.WriteLine("Active: " + test.DisplayActiveState());
        Console.WriteLine("Permanent state: " + test.DisplayPermanentState());
        Console.WriteLine("Reward: " + test.DisplayReward());
        Console.WriteLine("Value: " + test.Value());
        */
    }
}
