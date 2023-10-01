using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool Pressed = false;
    public Vector3 rot = new Vector3(1, 1, -1);
    
    public void Click()
    {
        Pressed = !Pressed;
    }

    private void Update()
    {
        if (Pressed) transform.Rotate(rot);
    }
}
