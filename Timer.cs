using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

public class Timer : MonoBehaviour {

    double czas = 0;
    string czas2 = "0";

    public Text tekst;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        czas += 1 * Time.deltaTime;
        czas = Math.Round(czas, 2);
        czas2 = czas.ToString();

        tekst.text = czas2;
       

    }
}
