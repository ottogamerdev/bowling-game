using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject ballPrefab;
    public GameObject[] pinsPrefab;

    // Start is called before the first frame update


    // spawnaa objektit prefabbien avulla, prefabbien koordinaatistoa muuttamalla voi vaihtaa spawnia 
    // (esim. keilan 1 XYZ koordinaatit 1,1,1 ==> 1,2,1
    void SpawnAll()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(pinsPrefab[i], pinsPrefab[i].transform.position, pinsPrefab[i].transform.rotation);
        }

        Instantiate(ballPrefab, ballPrefab.transform.position, ballPrefab.transform.rotation);
    }

    // SpawnAll kutsu
    void Awake()
    {
        SpawnAll();
    }
}
