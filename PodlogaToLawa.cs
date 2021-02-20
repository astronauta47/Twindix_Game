using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PodlogaToLawa : MonoBehaviour
{


    private void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.name == "Sphere" || colision.gameObject.name == "Sphere2" || colision.gameObject.name == "Sphere(Clone)")
        {
            if(!Trudnosc.PoziomTrudności)
            {
                string levelName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(levelName);
                Physics.gravity = new Vector3(0, -10, 0);
            }
           else if(Trudnosc.PoziomTrudności)
            {
                SceneManager.LoadScene("level 1");
            }
            
        }
    }

}
