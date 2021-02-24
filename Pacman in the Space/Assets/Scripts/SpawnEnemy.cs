using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    void Start(){
        StartCoroutine(Spawn(3));
    }

    void spawnGhost(){
        GameObject ghostObj = Instantiate(
                        enemyPrefab, 
                        gameObject.transform.position+new Vector3(2,0,0),
                        //new Vector3(1,5,0), 
                        Quaternion.identity);
        print("Заспавнило " + ghostObj.name);
    }

    public IEnumerator Spawn(int count){
        yield return new WaitForSeconds(1f);
        for(int i=0; i<count; i++){
            spawnGhost();
            yield return new WaitForSeconds(2f);
        }
    }


}

