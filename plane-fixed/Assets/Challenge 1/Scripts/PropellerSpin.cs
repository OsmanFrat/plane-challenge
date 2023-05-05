using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float turnSpeed = 70;
    
    void Update()
    {
        transform.Rotate(0,0,turnSpeed);
    }
}
