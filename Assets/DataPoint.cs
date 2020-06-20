using UnityEngine;

public class DataPoint
{
    public float Value { get; set; }
    public DataType DataType { get; set; }

    public DataPoint (float value, DataType dataType)
    {
        Value = value;
        DataType = dataType;
    }
}

