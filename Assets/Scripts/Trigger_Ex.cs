using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trigger_Ex : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI contador; //asignada por inspector
    float cont; 
    float contSegundos;


    // Start is called before the first frame update
    void Start()
    {
        cont = 0f;
        contSegundos = 0f;
    }
  
    private void OnTriggerEnter(Collider other) {
        GameObject obj = other.gameObject;
        string nombre = obj.name;
        Debug.Log("Entraste en el trigger de: " + nombre);     

        cont  = 0;   
    }

    private void OnTriggerStay(Collider other) {
        GameObject obj = other.gameObject;
        string nombre = obj.name;
        Debug.Log("Estas en el trigger de: " + nombre);

        contSegundos += Time.deltaTime;

        if(contSegundos >= 1.0f){
            cont++;
            contSegundos = 0;
            contador.text = cont.ToString();
        }


    }


    private void OnTriggerExit(Collider other) {
        GameObject obj = other.gameObject;
        string nombre = obj.name;
        Debug.Log("Saliste del trigger de: " + nombre);

        cont = 0;
        contador.text = "0";
    }

}
