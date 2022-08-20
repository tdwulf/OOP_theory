using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YellowShip : Ship
{

    public override int ShowCargo()
    {
        return Mathf.RoundToInt(Cargo * 3 );
    }
    public override int ShowShield()
    {
        return Mathf.RoundToInt(Shield*3);
    }
    public override int ShowHull()
    {
        return Mathf.RoundToInt(Hull*2);
    }

    

}
