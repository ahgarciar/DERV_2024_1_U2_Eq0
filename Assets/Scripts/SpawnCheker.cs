using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCheker : MonoBehaviour
{
    [SerializeField] ManagerSpawns manager;

    float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        tiempo  = 0;    
    }

     
    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if  (tiempo>= 1.5f){
            manager.createEnemy();
            tiempo = 0;
        }
    }
}
