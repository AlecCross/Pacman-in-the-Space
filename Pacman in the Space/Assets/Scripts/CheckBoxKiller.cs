using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoxKiller : MonoBehaviour
{            
       void OnTriggerEnter(Collider collider){
       if (collider.gameObject.tag == "GhostTag") {  
            GameObject.Find(collider.gameObject.name).SetActive(false);
        }
   }
}
