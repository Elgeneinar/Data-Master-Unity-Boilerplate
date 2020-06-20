using System.Collections.Generic;
using UnityEngine;

public class Reading
{

    public Sensor Sensor {get;set;}
    public List<DataPoint> DataPoints { get; set; }
    public Time Time { get; set; }

    public Reading (Sensor sensor)
    {
        Sensor = sensor;
        DataPoints = sensor.DataPoints;
        Time = new Time();
    }

}
