using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.instance;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>4f )
        {
            objectPooler.SpawnFromPool("Cactus", transform.position, Quaternion.identity);
            time = 0;
        }
        else if(time>2f && time<2.0005f)
        {
            objectPooler.SpawnFromPool("smallCactus", transform.position, Quaternion.identity);
        }
        

    }
}
