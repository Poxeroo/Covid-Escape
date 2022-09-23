using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    
    Rigidbody2D rigidB2D1;

    public float salto = 2f;

    public bool saltando = false;

    public bool muerte = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidB2D1 = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (saltando == true)
        {
            rigidB2D1.velocity = new Vector2(0f, salto);
        }
        NoSaltar();
    }

    public void saltar()
    {
        saltando = true;
    }

    public void NoSaltar()
    {
        saltando = false;
    }



    void OnTriggerEnter2D(Collider2D colision)//sobre escribimos esta funcion osea que obligatoria mente se debe llamar asi
    {
        //no obligatoria mente este se debe destruir pero se hace de buena practicar para no explotar las PCs
        if (colision.gameObject.tag == "Destructor")
        {
            Muerte();
        }

    }

    public void Muerte()
    {
        muerte = true;
    }





}
