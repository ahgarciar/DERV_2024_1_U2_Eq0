using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CuentaKills : MonoBehaviour
{    
    public TextMeshProUGUI txt_score;

    CambiarEscena cambia;

    // Start is called before the first frame update
    void Start()
    {
        cambia = GetComponent<CambiarEscena>();
    }

    // Update is called once per frame
    void Update()
    {
        double score =  Convert.ToDouble(txt_score.text);
        if(score == 5){ //= 5 porque tengo 5 elementos enemigos
            cambia.change(2); //index = 2 -> FIN
        }
    }
}
