using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aumentador : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AumentarGlobosAzules()
    {
        score += 10;
    }

    public void AumentarGlobos()
    {
        score ++;
    }

}
