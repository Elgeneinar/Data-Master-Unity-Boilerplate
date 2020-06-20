using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PollutionSource : MonoBehaviour
{

    public int pollutionValue = 0;


    private SphereCollider pollutionCollider;
    public int radius;

    DataType type; //implement this. The type of pollution



    void Start()
    {
        gameObject.tag = "pollution";

        pollutionCollider = GetComponent<SphereCollider>();

        pollutionCollider.radius = radius;
    }



    public int GetPollution()
    {
        return pollutionValue;
    }

    public void SetPollution(int p)
    {
        pollutionValue = p;
    }

    




}
