
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class AI : MonoBehaviour
{
    public GameObject Sphere;

    //Predkosc obrotu przeciwnika.
    public float predkoscObrotu = 6.0f;

    //Prędkość poruszania się przeciwnika.
    public float predkoscRuchu = 5.0f;
    //Odległość na jaką widzi przeciwnik.
    public float zasiegWzroku = 3000f;
    //Odstęp w jakim zatrzyma się obiekt wroga od gracza.
    public float odstepOdGracza = 1f;

    private Transform mojObiekt;
    private Transform gracz;
    private Vector3 pozycjaGraczaXYZ;

    // Use this for initialization
    void Start()
    {
        mojObiekt = transform;
        //Rigidbody pozwala aby na obiekt oddziaływała fizyka.
        //Wyłaczenie oddziaływanie fizyki na XYZ - 
        // jak obiekt będzie wchodził pod górkę to się przechyli prostopadle do zbocza a fizyka pociągnie go w dół i
        // obiekt się przewróci. POZATYM NIE CHCEMY ABY WRÓG SIĘ TAK DZIWNIE OBRACAŁ ;).
        //if (GetComponent<Rigidbody>())
        {
            //GetComponent<Rigidbody>().freezeRotation = true;
        }
    }


    void Update()
    {
        //Pobranie obiektu gracza.
        gracz = Sphere.transform;

        //Pobranie pozycji gracza.
        pozycjaGraczaXYZ = new Vector3(gracz.position.x, mojObiekt.position.y, gracz.position.z);

        //Pobranie dystansu dzielącego wroga od obiektu gracza.
        float dist = Vector3.Distance(mojObiekt.position, gracz.position);


        //Sprawdzenie czy gracz jest w zasięgu wzroku wroga.
        if (dist <= zasiegWzroku && dist > odstepOdGracza)
        {
            //Gracz w zasiegu wzroku wiec na neigo patrzymy

            //Teraz wykonujemy ruch wroga.
            //Vector3.MoveTowards - pozwala na zdefiniowanie nowej pozycji gracza oraz wykonanie animacji.
            //Pierwszy parametr obecna pozycja drógi parametr pozycja do jakiej dążymy (czyli pozycja gracza).
            //Trzeci parametr określa z jaką prędkością animacja/ruch ma zostać wykonany.
            mojObiekt.position = Vector3.MoveTowards(mojObiekt.position, pozycjaGraczaXYZ, predkoscRuchu * Time.deltaTime);

        }
        
        Quaternion rotation = Quaternion.LookRotation(pozycjaGraczaXYZ - mojObiekt.position);
        //Obracamy wroga w stronę gracza.
        mojObiekt.rotation = Quaternion.Slerp(mojObiekt.rotation, rotation, Time.deltaTime * predkoscObrotu);
    }
}