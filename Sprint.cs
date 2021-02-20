using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour {

    public int szybkość;
    public int wybór;
   

    private void OnTriggerStay(Collider colision)
    {
        GameObject think = colision.gameObject;
        Rigidbody rigibody = think.GetComponent<Rigidbody>();
        Vector3 veliocity = rigibody.velocity;

        
        if(wybór == 1)
        {
            veliocity.x = szybkość;
        }
        if (wybór == 2)
        {
            veliocity.y = szybkość;
        }

        rigibody.velocity = veliocity;


   


    }
}
