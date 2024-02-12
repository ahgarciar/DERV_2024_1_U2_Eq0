using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSpawns : MonoBehaviour
{
    [SerializeField] List<GameObject> spawns;
    [SerializeField] GameObject objetoEnemigo;

    int index;

    // Start is called before the first frame update
    void Start()
    {
        createEnemy();
    }

    public void createEnemy(){
        index = Random.Range(0, spawns.Count);
        GameObject obj =  Instantiate(objetoEnemigo,
         spawns[index].transform.position,
         spawns[index].transform.rotation         
        );
        Destroy(obj, 1f);
    }

}
