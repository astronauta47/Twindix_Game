using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class KoloroweKulki : MonoBehaviour {

    public GameObject jasnoniebiescy;
    public GameObject niebiescy;
    public GameObject zloci;
    public GameObject biali;
    public GameObject jasnozieloni;
    public GameObject zieloni;
    public GameObject szarzy;
    public GameObject pomaranczowi;
    public GameObject czerwoni;

    public Color myColor1;
    public Color myColor2;
    public Color myColor3;
    public Color myColor4;
    public Color myColor5;
    public Color myColor6;
    public Color myColor7;
    public Color myColor8;
    public Color myColor9;

    public MeshRenderer komponent;
    public MeshRenderer komponent2;

    public TextMesh Text;
    private int pomocnik;
    private int pomocnik2;
    public int liczba;

    //public Texture tekstura;

    public GameObject Wrog;
    public Transform Position;


    //public Vector3 pozycja;
    public int rand = 10;

    public double czas;
    public double czasy = 8;

    public GameObject Sphere;
    public Texture Kolor;
    private int pomocnik3;

    // Update is called once per frame
    private void Start()
    {
       
        
    }
    

    void Update()
    {
        czas += 1 * Time.deltaTime;
        if (czas <= 1) { czasy = Random.Range(6, 9); }

        if (czas >= 2 && czas <= 3) { rand = Random.Range(1, 10); }

        if (rand == 1) { komponent.material.color = myColor1; komponent2.material.color = myColor1; }
        if (rand == 2) { komponent.material.color = myColor2; komponent2.material.color = myColor2; }
        if (rand == 3) { komponent.material.color = myColor3; komponent2.material.color = myColor3; }
        if (rand == 4) { komponent.material.color = myColor4; komponent2.material.color = myColor4; }
        if (rand == 5) { komponent.material.color = myColor5; komponent2.material.color = myColor5; }
        if (rand == 6) { komponent.material.color = myColor6; komponent2.material.color = myColor6; }
        if (rand == 7) { komponent.material.color = myColor7; komponent2.material.color = myColor7; }
        if (rand == 8) { komponent.material.color = myColor8; komponent2.material.color = myColor8; }
        if (rand == 9) { komponent.material.color = myColor9; komponent2.material.color = myColor9; }

        if (rand == 10) { komponent.material.color = myColor8; komponent2.material.color = myColor6; }

        if (czas >= 2 && czas <= 3 && pomocnik3 == 0)
        {
            Sphere.GetComponent<Renderer>().material.mainTexture = Kolor;
            pomocnik3 += 1;
        }

        if (rand == 1)
        {
            if (czas >= czasy)
            {
                Usuwacz();
                jasnozieloni.SetActive(true);
            }
        }
        if (rand == 2)
        {
            if (czas >= czasy)
            {
                Usuwacz();
                jasnoniebiescy.SetActive(true);
            }
        }
        if (rand == 3)
        {
            if (czas >= czasy)
            {
                Usuwacz();
                niebiescy.SetActive(true);
            }
        }
        if (rand == 4)
        {
            if (czas >= czasy)

            {
                Usuwacz();
                zloci.SetActive(true);
            }
        }
        if (rand == 5)
        {
            if (czas >= czasy)
            {
                Usuwacz();
                zieloni.SetActive(true);
            }
        }
        if (rand == 6)
        {
            if (czas >= czasy)

            {
                Usuwacz();
                biali.SetActive(true);
            }
        }
        if (rand == 7)
        {
            if (czas >= czasy)

            {
                Usuwacz();
                szarzy.SetActive(true);
            }
        }
        if (rand == 8)
        {
            if (czas >= czasy)

            {
                Usuwacz();
                pomaranczowi.SetActive(true);
            }
        }
        if (rand == 9)
        {
            if (czas >= czasy)

            {
                Usuwacz();
                czerwoni.SetActive(true);
            }
        }

        if (czas >= 11 && czas <= 12)
        {
            jasnoniebiescy.SetActive(true);
            niebiescy.SetActive(true);
            zloci.SetActive(true);
            zieloni.SetActive(true);
            biali.SetActive(true);
            pomaranczowi.SetActive(true);
            szarzy.SetActive(true);
            czerwoni.SetActive(true);
            jasnozieloni.SetActive(true);
            czas = 0;
        }

        if(czas == 0)
        {
            pomocnik += 1;
            Text.text = pomocnik.ToString();
            if(pomocnik > PlayerPrefs.GetInt("Rekord"))
            {
                pomocnik2 = pomocnik;
                PlayerPrefs.SetInt("Rekord", pomocnik2);
                PlayerPrefs.Save();
                
            }
            Wrogowie();
        }
        
    }

    public void Usuwacz()
    {
        jasnozieloni.SetActive(false);
        niebiescy.SetActive(false);
        zloci.SetActive(false);
        zieloni.SetActive(false);
        biali.SetActive(false);
        pomaranczowi.SetActive(false);
        szarzy.SetActive(false);
        czerwoni.SetActive(false);
        jasnoniebiescy.SetActive(false);
    }


    public void Wrogowie()
    {

        if(pomocnik >= 5 && pomocnik < 10)
        {
            Instantiate(Wrog, Position.transform.position, Quaternion.identity);
        }
        if(pomocnik >= 10)
        {
            Instantiate(Wrog, Position.transform.position, Quaternion.identity);
            Instantiate(Wrog, Position.transform.position, Quaternion.identity);
        }
       
    }
}

