using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public enum EstadosDeJuego { Quieto, Jugando, Muerte, ListoIniciar, Victoria };

public class Juego : MonoBehaviour
{
    public Text textScore;
    public Text TextTimer;
    public float timer,segundos;
    
    public GameObject aumentador;

    public GameObject Nave;
    public GameObject PantallaScore;
    public GameObject PantallaInicio;
    public RawImage fondo;
    public GameObject PantallaWin;
    public GameObject PantallaDerrota;

    public float velocidadParalax = -0.04f;

    public GameObject Botones;

    public GameObject Reinicio;
    
    // Start is called before the first frame update
    void Start()
    {
        aumentador.GetComponent<Aumentador>().score = 30;

        PantallaInicio.SetActive(true);
        PantallaScore.SetActive(false);
        Nave.SetActive(false);
        PantallaWin.SetActive(false);
        Botones.SetActive(false);
        Reinicio.SetActive(false);
        PantallaDerrota.SetActive(false);

        Time.timeScale = 0;
        timer = Time.time - Time.time;
        InvokeRepeating("restar5", 10, 10);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            PantallaScore.SetActive(true);
            Nave.SetActive(true);
            PantallaInicio.SetActive(false);
            Botones.SetActive(true);
            Reinicio.SetActive(false);
            Time.timeScale = 1;
            Timer();
        }

        Paralax();
        textScore.text = aumentador.GetComponent<Aumentador>().score.ToString();

        chequeoVictoria();
        chequeoDerrota();
    }

    void Paralax()
    {
        // realizo el efecto paralax
        float velocidadfinal = velocidadParalax * Time.deltaTime; // esto es para limitar la velocidad por los diferentes tipos de pc(potentes o mier....)
        fondo.uvRect = new Rect(fondo.uvRect.x + velocidadfinal, 0f, 1f, 1f); //  esto es para hacer que se mueva a una velocidad  
    }

    public void chequeoVictoria()
    {
        if(aumentador.GetComponent<Aumentador>().score >= 500)
        {
            PantallaInicio.SetActive(false);
            PantallaScore.SetActive(false);
            Nave.SetActive(false);
            PantallaWin.SetActive(true);
            Botones.SetActive(false);
            Reinicio.SetActive(true);
            timer = 0;
            TextTimer.text = timer.ToString("00");
        }
    }

    public void chequeoDerrota()
    {
        if (Nave.GetComponent<Nave>().muerte == true || aumentador.GetComponent<Aumentador>().score == 0)
        {
            PantallaDerrota.SetActive(true);
            Nave.SetActive(false);
            PantallaInicio.SetActive(false);
            PantallaScore.SetActive(true);
            Botones.SetActive(false);
            Reinicio.SetActive(true);
            timer = 0;
            TextTimer.text = timer.ToString("00");
        }
    }

    public void Timer()
    {
        timer = Time.time;
        TextTimer.text = timer.ToString("00");
    }

    public void restar5()
    {
        aumentador.GetComponent<Aumentador>().score -= 5;
    }


}
