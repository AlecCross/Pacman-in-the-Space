using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrWasPickedUp : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        // определение столкновения с двумя разноименными объектами
        if (collider.gameObject.name == "Player") {  
            Destroy(gameObject);
        }
    }
}
