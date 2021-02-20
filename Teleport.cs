using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject sphere2;
    public GameObject sphere;
    public GameObject start;
    Vector3 vector3;
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Sphere2")
        {
            sphere.transform.position = start.transform.position;
        }
        if(collider.gameObject.name == "Sphere2")
        {
            sphere2.transform.position = start.transform.position;
        }
    }
}
