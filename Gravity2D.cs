using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity2D : MonoBehaviour {

	
	void Start ()
    {
		Physics.gravity = new Vector3(0, -25, 0);
	}
	
	
	void Update ()
    {
       
        
        if (Input.GetKeyDown(KeyCode.Space) && Physics.gravity == new Vector3(0, -25, 0))
        {
            Physics.gravity = new Vector3(0, 25, 0);
            //Debug.Log(1);
        }
        else
        if (Input.GetKeyDown(KeyCode.Space) && Physics.gravity == new Vector3(0, 25, 0))
        {
            Physics.gravity = new Vector3(0, -25, 0);
            //Debug.Log(2);
        }


    }
}
