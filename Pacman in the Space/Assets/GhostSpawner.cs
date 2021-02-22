using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    [SerializeField]
    float xLimit;
    [SerializeField]
    float[] xPositions;//Different X positions
    [SerializeField]
    GameObject[] enemyPrefabs;
    [SerializeField]
    Wave[] wave;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Wave{
    public float delatTime;
    public float spawnAmount;
}
