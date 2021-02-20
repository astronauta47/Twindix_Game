using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Pauza : MonoBehaviour
{

    public Canvas Menu;
    public Canvas Zapytanie;
    public Canvas Ustawienia;
    public Canvas PoziomTrudnosci;
    public Canvas Sterowanie;
    public Button start;
    public Button poziomtrudnosci;
    public Button ustawienie;
    public Button exit;
    public Button sterowanie;
    public bool restart;

    public Text tekst;
    public Color c;


    void Start()
    {
        Menu = (Canvas)GetComponent<Canvas>();
        start = (Button)GetComponent<Button>();
        ustawienie = (Button)GetComponent<Button>();
        exit = (Button)GetComponent<Button>();
        poziomtrudnosci = (Button)GetComponent<Button>();
        sterowanie = (Button)GetComponent<Button>();

        Menu.enabled = false;
        Zapytanie.enabled = false;
        Ustawienia.enabled = false;
        if (Sterowanie != null) { Sterowanie.enabled = false; }
        if (PoziomTrudnosci != null) { PoziomTrudnosci.enabled = false; }

        Time.timeScale = 1;//Zatrzymanie czasu.
        Cursor.visible = Menu.enabled;//Ukrycie pokazanie kursora myszy.
        Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
        
    }


    void Update()
    {

        
        
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                Menu.enabled = !Menu.enabled;

                Cursor.visible = Menu.enabled;

            if (Menu.enabled)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
                Time.timeScale = 0;
                Zapytanie.enabled = false;
                Ustawienia.enabled = false;
                //Sterowanie.enabled = false;
                AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
                foreach (AudioSource source in aSources)

                source.Pause();
            }
                {
                    

                    if (PoziomTrudnosci != null) { PoziomTrudnosci.enabled = false; }


            }
                if (!Menu.enabled)
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Time.timeScale = 1;

                    AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
                    foreach (AudioSource source in aSources)
                
                    source.Play();

                }
            
        }
    }
    public void Kontynuuj()
    {
        Menu.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        AudioSource[] aSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource source in aSources)
        source.Play();
        
    }

    public void Wyjdź()
    {
        if(restart)
        {
            SceneManager.LoadScene("menu");
            Trudnosc.PoziomTrudności = false;
            Trudnosc.PoziomTrudności2 = false;
            Physics.gravity = new Vector3(0, -10, 0);
        }
        if(!restart)
        {
            Zapytanie.enabled = true;
        }

    }
    public void Exit()
    {
        SceneManager.LoadScene("Start");
    }

    public void PowrótDoMenu()
    {
        Zapytanie.enabled = false;
        Ustawienia.enabled = false;
        PoziomTrudnosci.enabled = false;
        Sterowanie.enabled = false;
    }

    public void UstawieniaOpen()
    {
        Ustawienia.enabled = true;
    }

    public void PoziomTrudnosciOpen()
    {
        PoziomTrudnosci.enabled = true;
    }
    public void SterowanieOpen()
    {
        Sterowanie.enabled = true;
    }
    public void Test()
    {
        tekst.color = c;
    }
    
}
