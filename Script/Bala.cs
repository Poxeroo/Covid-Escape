using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * -20 * Time.deltaTime; 
    }

    void OnTriggerEnter2D(Collider2D colision)//sobre escribimos esta funcion osea que obligatoria mente se debe llamar asi
    {
        //no obligatoria mente este se debe destruir pero se hace de buena practicar para no explotar las PCs
        if (colision.gameObject.tag == "Destructor")
        {
            Destroy(gameObject);//Destruyo al enemigo al chocar con el box collider colocado atras del personaje
        }

    }
}

