using System;
using System.Threading;

namespace DelegatesExample
{
    // I have combined the classes in one .cs file for 
    // demonstration purposes only.
    
    public class MessageEventArgs : EventArgs
    {
        public string Msg { get; set; }
    }

    public class MessageProcessor
    {
        // 1 - Define Delagate
        public delegate void ProcessEventHandler(object source, MessageEventArgs args);

        // 2 - Define an event based on that delegate
        public event ProcessEventHandler Processed;

        //NOTE: 
        // Due to advancement in .Net you can omit step 1 and 2
        // as the framework provides us with an Eventhandler delegate
        //public event EventHandler<MessageEventArgs> Processed;

        // 3 - Define a method which would be consumed by subscribers
        public void Process(string message)
        {
            Console.WriteLine("Processing Messages");
            Thread.Sleep(3000);

            //Notify all Subscribers
            OnProcessed(message);
        }

        // 4 - Raise the notification event 
        // by convention event publisher methods must be 
        // protected virtual void and start with 'On'
        protected virtual void OnProcessed(string message)
        {
            //Check if there are subscribers to the event and raise the subscriber's event handlers
            Processed?.Invoke(this, new MessageEventArgs() { Msg = message });
        }
    }

    class EventsAndDelegates
    {
        static void Main(string[] args)
        {
            // 5 - Initalize the publisher and subscribers
            var message = new MessageProcessor(); // Publisher
            var subscriber1 = new Subscriber1(); // Subscriber
            var subscriber2 = new Subscriber2(); // Subscriber

            // 6 - Subscribe to the publisher event
            message.Processed += subscriber1.OnProcess;
            message.Processed += subscriber2.OnProcess;

            // 7 - trigger custom logic
            message.Process("Hello World!");
        }
    }

    public class Subscriber1
    {
        // 8 - Define custom event handler which would be triggred once 
        // the Process event has been completed
        public void OnProcess(object source, MessageEventArgs e)
        {
            Console.WriteLine($"Processed from Subscriber 1 with message: {e.Msg}");
        }
    }

    public class Subscriber2
    {
        public void OnProcess(object source, MessageEventArgs e)
        {
            Console.WriteLine($"Processed from Subcriber 2 with message: {e.Msg}");
        }
    }
}
