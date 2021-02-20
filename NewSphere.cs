using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSphere : MonoBehaviour
{

    public GameObject Sphere;
    public Vector3 position;
    public bool Level7;

    public Texture Kolor;

    public Color myColor1;
    public MeshRenderer komponent;

    bool bol;

    private void Start()
    {
        bol = Trudnosc.PoziomTrudności2;
        if(bol == true && !Level7)
        {
            Instantiate(Sphere, position, Quaternion.identity);
            komponent.material.color = myColor1;
            Sphere.GetComponent<Renderer>().material.mainTexture = Kolor;
        }
        if(bol == true && Level7)
        {
            Sphere.transform.position = position;
        }
    }



}
