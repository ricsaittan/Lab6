using System.Text.Json;
using System.Text.Json.Nodes;

class Event
{
    //Setters and getters for EventNumber and Location
    public int EventNumber
    {get; set;}
    public string Location
    {get; set;}

    //Serialization Method that creates the "event.json" file
    public void Serialization()
    {
        string jsonString = JsonSerializer.Serialize(this);
        File.WriteAllText("event.json", jsonString);
    }

    //Deserialization Method that reads the Json file and creates the Event object again.
    //Also reads the objects Properties
    public void DeSerialization()
    {
        string jsonString = File.ReadAllText("event.json");
        Event temp = JsonSerializer.Deserialize<Event>(jsonString);
        Console.WriteLine($"Event Number: {temp.EventNumber}");
        Console.WriteLine($"Location: {temp.Location}");
    }

    //ReadFromFile Method that reads the "event.json" file while writes in it.
    //Uses seek to get the bytes of the file and retranslates it back into char type.
    public void ReadFromFile()
    {
        using (StreamWriter write = new StreamWriter("event.json"))
        {
            write.Write("Hackathon");
        }
        StreamReader read = new StreamReader("event.json");
        string line = read.ReadLine();
        Console.WriteLine($"In Word: {line}");
        using (FileStream read2 = new FileStream("event.json", FileMode.Open, FileAccess.Read))
        { 
            read2.Seek((read2.Length - read2.Length) ,SeekOrigin.Begin);
            Console.WriteLine($"The First Character is: \"{(char)read2.ReadByte()}\"");
            read2.Seek(read2.Length/2, SeekOrigin.Begin);
            Console.WriteLine($"The Middle Character is: \"{(char)read2.ReadByte()}\"");
            read2.Seek(read2.Length -1 , SeekOrigin.Begin);
            Console.WriteLine($"The last Character is: \"{(char)read2.ReadByte()}\"");
        }
    }
}
