using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Animal
{
    public override float speed
    {
        get { return speed; }
        set { speed = 8; }
    }


    public new void Update()
    {
        if (isDestroyed == true)
        {
            Debug.Log("Reduce point");
        }
        base.Update();
    }
}
