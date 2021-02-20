using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WyświetlCzas : MonoBehaviour
{
    public TextMesh text;
    public GameObject wynik;
         

	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(wynik);
    }
	
	// Update is called once per frame
	void Update ()
    {
        text.text = PlayerPrefs.GetString("Czas");
       
    }
}
