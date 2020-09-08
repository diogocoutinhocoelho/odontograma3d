using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statusManager : MonoBehaviour
{
   
    void Update()
    {
        Vector3 yTarget = Camera.main.transform.forward - (transform.forward * Vector3.Dot(Camera.main.transform.forward, transform.forward));
        
        Quaternion desiredRotation = Quaternion.LookRotation(transform.forward, yTarget);
        
        gameObject.transform.rotation = desiredRotation;
    }
}
