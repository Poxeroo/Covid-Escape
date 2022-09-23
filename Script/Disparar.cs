using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public GameObject bala;
    public Transform pistola;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void disparo()
    {
        Instantiate(bala, pistola.position, Quaternion.identity);
    }

}
