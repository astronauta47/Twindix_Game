using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Przejście : MonoBehaviour {

    int GateA = 0;
    int GateB = 0;
    public GameObject Meta;
    public GameObject miejsceMeta;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Sphere" || other.gameObject.name == "Sphere2")
        {
            SceneManager.LoadScene("Level 6");
        }
        if (other.gameObject.name != "Sphere" && other.gameObject.name != "Sphere2" && other.gameObject.name != "LegoBox")
        {
            GateA = 1;
        }
        if (other.gameObject.name == "LegoBox")
        {
            GateB = 1;
        }
        if(GateB == 1 && GateA == 1)
        {
            Meta.transform.position = miejsceMeta.transform.position;
        }
    }
}
