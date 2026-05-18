namespace DelegatesEventsLambdas.EventsPubSub
{
    class Publisher
    {
        int flag = 0;

        // Declare the event:
        public event ValueChangedEventHandler ValueChanged; //the "list" of methods that will be called when the event is raised

        public int Flag 
        { 
            get 
            { 
                return flag; 
            } 
            set 
            { 
                flag = value; 
                RaiseEvent(); // raise the event whenever Flag changes
            } 
        }


        //Raise the event:
        public void RaiseEvent()
        {
            if (ValueChanged != null)
            {
                ValueChanged.Invoke(flag); // this will call the method(s) that are subscribed to the event, passing the current value of flag as an argument
            }
        }

    }
}
