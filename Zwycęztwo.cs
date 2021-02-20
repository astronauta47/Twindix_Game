using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zwycęztwo : MonoBehaviour {

    public GameObject sphere;
    public GameObject sphere2;
    public string Wygrana;

    private void Update()
    {
        if(PlayerPrefs.GetInt(Wygrana) == 1 && sphere2 != null)
        {
            sphere.transform.position = sphere2.transform.position;
            Destroy(sphere2);
        }
    }
}
