using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionCubos : MonoBehaviour
{

    [SerializeField]
    GameObject objeto;
    
    [SerializeField]
    GameObject ubicacion;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            GameObject obj = Instantiate(objeto, 
                                ubicacion.transform.position, 
                                ubicacion.transform.rotation);
            Destroy(obj, 2); //segundos
        }        
    }
}
