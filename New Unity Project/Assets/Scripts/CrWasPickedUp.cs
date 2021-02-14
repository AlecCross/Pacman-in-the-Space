using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrWasPickedUp : MonoBehaviour
{
    void OnCollisionEnter(Collision myCollision) {
        // определение столкновения с двумя разноименными объектами
        if (myCollision.gameObject.name == "Player") {  
            Destroy(gameObject);
        }
    }
}
