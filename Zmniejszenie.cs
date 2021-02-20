using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zmniejszenie : MonoBehaviour {

    public float wielkość;
    public GameObject sphere;
    public GameObject sphere2;
    Vector3 vector3;

    private void OnTriggerEnter(Collider collider)
    {
        vector3.x = wielkość;
        vector3.y = wielkość;
        vector3.z = wielkość;
        if (collider.gameObject.name == "Sphere")
        {
            sphere.transform.localScale = vector3;
        }
        if(collider.gameObject.name == "Sphere2")
        {
            sphere2.transform.localScale = vector3;
        }
    }
}
