
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{

    static void Main(string[] args)
    {
        Event temp = new Event();
        temp.EventNumber = 1;
        temp.Location = "Calgary";
        temp.Serialization();
        temp.DeSerialization();
        temp.ReadFromFile();
    }
}