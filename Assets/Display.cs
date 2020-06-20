using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{

    public Text textBox;
    public DataStorer dataStorer;



    private List<string> GenerateDisplayText()
    {
        List<string> text = new List<string>();

        foreach (List<Reading> readingList in dataStorer.StoredReadings)
        {
            string t = "";
            foreach (Reading reading in readingList)
            {
                t += "SensorId: ";
                t += reading.Sensor.SensorId;
                t += "\n";
                foreach (DataPoint dataPoint in reading.Sensor.DataPoints)
                {
                    t += dataPoint.DataType.ToString();
                    t += dataPoint.Value.ToString(); //float.tostring gjør det jeg vil håper jeg
                    t += "\n";
                }
                
            }
            text.Add(t);
            
        }

        return text;
    }


    private void SetDisplayText(int depth, List<string> text)
    {
        for (int i=0; i<depth; i++)
        {
            textBox.text += text[i];
        }
    }



    public void UpdateDisplayText(int depth)
    {
        SetDisplayText(depth, GenerateDisplayText());
    }


    void Update ()
    {
        UpdateDisplayText(5);
    }

}
