using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroColision2 : MonoBehaviour
{
    CuentaKills cuenta;

    // Start is called before the first frame update
    void Start()
    {
        cuenta = GetComponent<CuentaKills>();
    }

    int cont = 0;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {        
        string name = other.gameObject.name;
        string tag = other.gameObject.tag;
        Debug.Log("Entra en colision con: " + name + " de tag:" + tag);

        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
            cont++;
            cuenta.txt_score.text = cont.ToString();
        }

    }


}
