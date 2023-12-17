// Interface allows for consitent way to retrieve the current time 
// accross different implementations of interface for future consistency/flexibility
public interface ITimeService   // declaring interface
{
    string GetCurrentTime();    // method is declared with no parameters and returns a string
}

