using System;
using System.Threading;

public class SingleAppInstance
{
    private static Mutex mutex = new Mutex();

    static void Main()
    {
    }

    public bool StartMutex()
    {
        Console.WriteLine("{0} is requesting mutual exclusion", Thread.CurrentThread.Name);
        return mutex.WaitOne(1000);
    }

    public void FreeMutex()
    {
        mutex.ReleaseMutex();
        mutex.Dispose();
    }

    public void CheckoutMutex(bool flag)
    {
        if (flag)
        {
            Console.WriteLine("{0} has reached the protected area", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("{0} has left the protected area", Thread.CurrentThread.Name);
            FreeMutex();
        } else
        {
            Console.WriteLine("{0} will not reach the mutual exclusion", Thread.CurrentThread.Name);
        }
    }

    /*public static bool UseMutex()
    {
        Console.WriteLine("{0} is requesting mutual exclusion", Thread.CurrentThread.Name);
        bool flag = mutex.WaitOne(1000);
        if (flag)
        {
            Console.WriteLine("{0} has reached the protected area",
                Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("{0} has left the protected area",
                Thread.CurrentThread.Name);

            mutex.ReleaseMutex();
            Console.WriteLine("{0} has released mutual exclusion",
                              Thread.CurrentThread.Name);
        }
        else
        {
            Console.WriteLine("{0} will not reach the mutual exclusion",
                              Thread.CurrentThread.Name);
        }
        return flag;
    }*/
}

/*
using System;
using System.Threading;

public class SingleAppInstance
{
    private static Mutex mutex = new Mutex();

    static void Main()
    {
        SingleAppInstance sai = new SingleAppInstance();
        sai.LaunchThreads();
    }

    public void LaunchThreads()
    {
        for (int i = 0; i < 3; i++)
        {
            Thread thr = new Thread(new ThreadStart(UseMutex));
            thr.Name = String.Format("thread{0}", i + 1);
            thr.Start();
        }
    }

    public static bool UseMutex()
    {
        Console.WriteLine("{0} is requesting mutual exclusion", Thread.CurrentThread.Name);
        bool flag = mutex.WaitOne(1000);
        if (flag)
        {
            Console.WriteLine("{0} has reached the protected area",
                Thread.CurrentThread.Name);

            Thread.Sleep(2000);

            Console.WriteLine("{0} has left the protected area",
                Thread.CurrentThread.Name);

            mutex.ReleaseMutex();
            Console.WriteLine("{0} has released mutual exclusion",
                              Thread.CurrentThread.Name);
        }
        else
        {
            Console.WriteLine("{0} will not reach the mutual exclusion",
                              Thread.CurrentThread.Name);
        }
        return flag;
    }
}*/