using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reborn : MonoBehaviour
{

    [SerializeField]
    GameObject spawn_point;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        if  (y < -10f){
            transform.position = spawn_point.transform.position;
        }
    }
}
