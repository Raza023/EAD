using System;
using System.Collections;

namespace prac
{
    delegate void EventDele(object sender,MyeventArgs e);

    class MyeventArgs: EventArgs
    {
        public int Count { get; set; }
        public object Value { get; set; }
    }

    class MyArrayList: ArrayList          //publisher class
    {
        public event EventDele delVar=null;
        MyeventArgs e = new MyeventArgs();
        public MyArrayList()
        {
            e.Count = 0;
            e.Value = "";
        }

        // public void onAdded(object value)
        // {
        //     if(delVar!=null)
        //     {
        //         e.Count += 1;
        //         e.Value = value;
        //         delVar.Invoke(this,e);
        //     }
        // }
        public override int Add(object value)
        {
            // onAdded(value);
            if(delVar!=null)
            {
                e.Count += 1;
                e.Value = value;
                delVar.Invoke(this,e);
            }
            return base.Add(value);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList l = new MyArrayList();
            l.delVar += delegate (object sender,MyeventArgs e)   //subscribing
            {
                Console.WriteLine($"Object added by {sender.ToString()} and {e.ToString()} and count: {e.Count} and Value: {e.Value}"); 
            };
            l.Add(1);
            l.Add("2");
        }
    }
}