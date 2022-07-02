using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Animal
{
    public new void Update()
    {
        if(isDestroyed == true)
        {
            Debug.Log("Add point");
        }
        base.Update();
    }
}
