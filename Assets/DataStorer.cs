using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorer
{
    //hvis nesting er et problem: 
    //lag snapshot objekt som har en liste av readings som eneste medlem
    //public List<Snapshot> snapshots;

    public List<List<Reading>> StoredReadings { get; set; }


    public DataStorer()
    {
        StoredReadings = new List<List<Reading>>();
    }

    public DataStorer (List<List<Reading>> StoredReadings)
    {
        this.StoredReadings = StoredReadings;
    }

    public void StoreReadings(List<Reading> readings)
    {
        StoredReadings.Add(readings);
    }

}
