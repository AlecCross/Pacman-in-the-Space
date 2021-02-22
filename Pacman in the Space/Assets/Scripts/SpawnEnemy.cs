using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    void Start(){
        spawnGhost();
    }

    void spawnGhost(){
        GameObject ghostObj = Instantiate(
                                        enemyPrefab, 
                                        new Vector3(0, 0, 0), 
                                        Quaternion.identity);
    }
}

