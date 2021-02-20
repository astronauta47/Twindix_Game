using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Warstwa : MonoBehaviour {

    public GameObject bariera;
    public GameObject Sphere;
    public GameObject pozycja;
    public Vector3 pozycja2;
    public GameObject kamera;
    private bool spacja;
    private Animator anim;

    private void Start()
    {
        anim = (Animator)kamera.GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {   
        if(other.gameObject == Sphere)
        {
            bariera.SetActive(true);
            Sphere.transform.position = pozycja.transform.position;
            anim.SetTrigger("New Bool");
            spacja = false;
        }
        
    }


    void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Space) && spacja == false)
        {
            bariera.SetActive(false);
            spacja = true;
            if (kamera.transform.position == pozycja2)
            {
                anim.SetTrigger("leveldown");
            }
            else
            {
                anim.SetTrigger("LevelDown2");
            }
        }
    }
    

}
