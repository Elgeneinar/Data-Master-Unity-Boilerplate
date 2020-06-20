using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sensor : MonoBehaviour
{

    public int sensorRadius = 10; //tror ikke denne gjør noe?

    public string SensorId { get; set; }

    public List<PollutionSource> pollutionNearby;

    public List<DataPoint> DataPoints = new List<DataPoint>();

    //Data points vet om typer
    public List<DataType> DataTypes; //ta dette seinere homie 😊






    public Sensor()
    {
        SensorId = GenerateSensorId();
    }

    public Sensor (string sensorId)
    {
        SensorId = sensorId;
    }

    private string GenerateSensorId()
    {
        return "GenerateSensorId Not yet implemented";
    }




    //add all game objects in range with tag "pollution" to PollutionNearby list
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        if (other.tag == "pollution")
        {
            pollutionNearby.Add(other.GetComponent<PollutionSource>());
        }
    }




    //get readings from pollution sources nearby
    void GenerateData ()
    {
        float pollutionAmount = 0f;
        

        foreach (PollutionSource pollutionSource in pollutionNearby)
        {
            pollutionAmount += pollutionSource.GetPollution(); //endre på dette
        }

        DataPoints.Add(new DataPoint(pollutionAmount, new DataType()));
        Debug.Log(pollutionAmount);
    }




    //not that often
    void Update()
    {
        if (pollutionNearby.Count>0)
        {
            GenerateData();
        }
        
    }

}
