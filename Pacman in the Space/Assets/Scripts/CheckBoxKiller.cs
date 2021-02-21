using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoxKiller : MonoBehaviour
{            
       void OnTriggerEnter(Collider collider){
       print("Зашло в метод OnCollisionEnter");
       if (collider.gameObject.tag == "GhostTag") {  
            Destroy(GameObject.Find(collider.gameObject.name));
        }
   }
}
