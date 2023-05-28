using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WindowsFormsApp1.Classes;

public class JsonDatabase
{
    private readonly string filePath;

    public JsonDatabase(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Vehicles> GetAllVehicles()
    {
        string jsonData = File.ReadAllText(filePath);
        var data = JsonConvert.DeserializeObject<Dictionary<string, List<Vehicles>>>(jsonData);

        return data["Vehicles"];
    }

    public void AddVehicles(Vehicles Vehicles)
    {
        List<Vehicles> Vehicless = GetAllVehicles();
        Vehicless.Add(Vehicles);

        SaveChanges(Vehicless);
    }

    private void SaveChanges(List<Vehicles> Vehicless)
    {
        var data = new Dictionary<string, List<Vehicles>>
        {
            { "Vehicles", Vehicless }
        };

        string jsonData = JsonConvert.SerializeObject(data);
        File.WriteAllText(filePath, jsonData);
    }
}

