using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedShip : Ship
{

    public override int ShowSpeed()
    {
        return Mathf.RoundToInt(Speed*1.5f);
    }
    public override int ShowCargo()
    {
        return Mathf.RoundToInt(20.0f);
    }
    public override int ShowShield()
    {
        return Mathf.RoundToInt(Shield*2);
    }
    public override int ShowHull()
    {
        return Mathf.RoundToInt(Hull*2);
    }
    public override int ShowDamage()
    {
        return Mathf.RoundToInt(Damage*2);
    }

    
}
