using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trudnosc : MonoBehaviour
{
    static public bool PoziomTrudności;
    static public bool PoziomTrudności2;
    public Text hard;
    public Text VeryHard;
    public Text normal;

    public void Start()
    {
        normal.enabled = true;
        hard.enabled = false;
        VeryHard.enabled = false;

        PoziomTrudności = false;
        PoziomTrudności2 = false;
    }

    public void PoziomkaEasy()
    {
        PoziomTrudności = false;
        PoziomTrudności2 = false;

        normal.enabled = true;
        hard.enabled = false;
        VeryHard.enabled = false;
    }

        public void PoziomkaHard()
    {
        PoziomTrudności = false;
        PoziomTrudności2 = true;

        hard.enabled = true;
        normal.enabled = false;
        VeryHard.enabled = false;
    }

    public void PoziomkaVeryHard()
    {
        PoziomTrudności = true;
        PoziomTrudności2 = false;

        VeryHard.enabled = true;
        hard.enabled = false;
        normal.enabled = false;
    }
}
