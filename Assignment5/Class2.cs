//using System;
//using System.Threading;
//using System.Threading.Tasks;



////Sample Solution Using Timer






//class Class2
//{
//    private static Timer timer;

//    static void Main(string[] args)
//    {
//        timer = new Timer(callback: new TimerCallback(TimerTask),state: null,dueTime: 0,period: 86400000);
//        while (true)
//        {}
        
//    }

//    private static void TimerTask(object timerState)
//    {
//        Console.WriteLine("Function Called at {0}",DateTime.Now);
//    }


//}