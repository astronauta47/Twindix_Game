using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public Transform box1;
    Vector3 vector;
    
    void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.name == "Sphere" || colision.gameObject.name == "Sphere2")
        {

            
        }

        
    }
}