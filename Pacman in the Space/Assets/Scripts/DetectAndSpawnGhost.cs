using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAndSpawnGhost : MonoBehaviour
{
    private SpawnEnemy spawnEnemy;
    GameObject spawner;
    // Start is called before the first frame update
    //GameObject player = GameObject.Find("Player");
    void Start()
    {
        spawner = GameObject.Find("SpawnEnemy");
        spawnEnemy = spawner.GetComponent<SpawnEnemy>();
    }
    void OnTriggerExit(Collider other){
        StartCoroutine(
                        ReactionOnDetect(other)
                      );
    }
    IEnumerator ReactionOnDetect(Collider collider){
        
        if(collider.tag=="Spawn"){
            print("Определён игрок");
            StartCoroutine(spawnEnemy.Spawn(1));
            yield return new WaitForSeconds(1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
