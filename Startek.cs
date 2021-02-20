using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Startek : MonoBehaviour {

    public Canvas Ustawienia;
    public Canvas Autor;
    public Canvas G;

    public void Start()
    {
        Ustawienia.enabled = false;
        Autor.enabled = false;
    }

    public void Graj()
    {
        SceneManager.LoadScene("menu");
        Trudnosc.PoziomTrudności = false;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void UstawieniaOpen()
    {
        Ustawienia.enabled = true;
    }

    public void Powrot()
    {
        Ustawienia.enabled = false;
        Autor.enabled = false;
        G.enabled = true;
    }
    
    public void Autorzy()
    {
        Autor.enabled = true;
        G.enabled = false;
    }
}
