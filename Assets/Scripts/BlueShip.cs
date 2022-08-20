using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlueShip : Ship
{
    

    override public int ShowSpeed()
    {
        return Mathf.RoundToInt(Speed*2);
    }

    override public int ShowWarp()
    {
        return Mathf.RoundToInt(Warp*2);
    }

    override public int ShowShield()
    {
        return Mathf.RoundToInt(Shield*2);
    }

}
