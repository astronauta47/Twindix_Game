using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    public Vector3 grawity;
    public int space;

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Physics.gravity = grawity;
        }

        if(space == 1)
        {
            Physics.gravity = grawity;
        }
    }
}

