using StatePattern.model;

class Program
{
    static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight();

        //  traffic light changing states
        for (int i = 0; i < 6; i++)
        {
            trafficLight.Change();
         
        }
    }
}