public void Wait(int time) 
{           
    Thread thread = new Thread(delegate()
    {   
        System.Threading.Thread.Sleep(time);
    });
    thread.Start();
    while (thread.IsAlive)
    Application.DoEvents();
}
using System;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        MessageBox.Show("Hello, and welcome to Untitled_GaMe!");
        Wait(5000);
    }
}

