
using System.Text.Json;
using System.Text.Json.Nodes;
namespace Main
{
    //Main class Program
    class Program
    {

        //Main method that is automatically called when program starts.
        static void Main(string[] args)
        {
            //Creates a temporary Object of Event and sets the properties while calling the Event's Methods.
            Event temp = new Event();
            temp.EventNumber = 1;
            temp.Location = "Calgary";
            temp.Serialization();
            temp.DeSerialization();
            temp.ReadFromFile();
        }
    }
}
