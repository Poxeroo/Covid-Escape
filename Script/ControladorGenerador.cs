using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorGenerador : MonoBehaviour
{
    public GameObject[] Globos;
    public int opcion;
    public int opcionGlobo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generador",1f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generador() 
    { 
        opcion = Random.Range(1, 5);
        opcionGlobo = Random.Range(0, 3);

       // if(opcion == 1)
        //{
            Instantiate(Globos[opcionGlobo], transform.position, Quaternion.identity);
       // }
       /* else if (opcion == 2)
        {
            Instantiate(Globos[opcionGlobo], transform.position, Quaternion.identity);
        }
        else if (opcion == 3)
        {
            Instantiate(Globos[opcionGlobo], transform.position, Quaternion.identity);
        }
        else if (opcion == 4)
        {
            Instantiate(Globos[opcionGlobo], transform.position, Quaternion.identity);
        }
        else if (opcion == 5)
        {
            Instantiate(Globos[opcionGlobo], transform.position, Quaternion.identity);
        }*/


    }

}
