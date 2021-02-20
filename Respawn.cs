using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public Light light1;

	void Start ()
    {
        Light light = GameObject.Instantiate(light1);


        light.color = Color.white;
        light.intensity = 0.001f;
        RenderSettings.ambientLight = Color.white * 0.3f;

	}
	
	
}
