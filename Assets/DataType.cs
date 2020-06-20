using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType
{
    
    enum Types { pm10, pm25}

    private Types type;

    public DataType ()
    {
        type = Types.pm10; //Implementation needed
    }

    
    public override string ToString()
    {
        if (type.Equals(Types.pm10)){
            return "pm10";
        }
        if (type.Equals(Types.pm10))
        {
            return "pm2.5";
        }

        return "no type";
    }
}
