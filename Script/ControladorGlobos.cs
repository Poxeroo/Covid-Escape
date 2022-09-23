using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorGlobos : MonoBehaviour
{
    public float speed;
    public GameObject aumentador;
    //public GameObject generadorGlobos;

    // Start is called before the first frame update
    void Start()
    {
        asignarPosicion();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Globo")
        {
            speed = Random.Range(1.5f, 4.5f);
            transform.Translate(Vector2.up *speed* Time.deltaTime);
        }
        if (this.gameObject.tag == "GloboAzul")
        {
            speed = Random.Range(4.5f, 5.5f);
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        
    }

    void OnTriggerEnter2D(Collider2D colision)
    {
        
        if (colision.gameObject.tag == "Destructor")
        {
            Destroy(gameObject);  
        }
        else if (colision.tag == "Bala" && this.tag == "GloboAzul")
        {
            aumentador.GetComponent<Aumentador>().AumentarGlobosAzules();
            Destroy(this.gameObject);
        }
       else if (colision.tag == "Bala" && this.tag == "Globo")
        {
            aumentador.GetComponent<Aumentador>().AumentarGlobos();
            Destroy(this.gameObject);
        }

    }


    void asignarPosicion()
    {
        int opcion = Random.Range(1, 6);

        if (opcion == 1)
        {
            this.gameObject.transform.position = new Vector2(0f, -6.17f);
        }
        if (opcion == 2)
        {
            this.gameObject.transform.position = new Vector2(-2.11f, -6.17f);
        }
        if (opcion == 3)
        {
            this.gameObject.transform.position = new Vector2(-3.91f, -6.17f);
        }
        if (opcion == 4)
        {
            this.gameObject.transform.position = new Vector2(-5.51f, -6.17f);
        }
        if (opcion == 5)
        {
            this.gameObject.transform.position = new Vector2(-7.51f, -6.17f);
        }
        if (opcion == 6)
        {
            this.gameObject.transform.position = new Vector2(-8.1f, -6.17f);
        }
    }
}
