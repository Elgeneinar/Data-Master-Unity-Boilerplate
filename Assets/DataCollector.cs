using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{
    //Skal ikke være monobehaviour?
    public List<Sensor> sensors;
    public DataStorer dataStorer;
    

    public List<Reading> GenerateReadings()
    {
        List<Reading> currentReadings = new List<Reading>();

        foreach (Sensor sensor in sensors){
            currentReadings.Add(new Reading(sensor));
        } 

        return currentReadings;
    }

    public void StoreData(List<Reading> readings)
    {
        dataStorer.StoreReadings(readings);
    }
    

}
