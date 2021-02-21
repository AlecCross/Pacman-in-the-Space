using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalJump : MonoBehaviour
{
    public bool TestItem = true;

     void OnTriggerEnter(Collider collider){
       if (collider.gameObject.name == "Portal") {  
            gameObject.transform.position = GameObject.Find("Portal2").transform.position+ new Vector3(1, 0, 0);
        }
        else if(collider.gameObject.name == "Portal2") {  
            gameObject.transform.position = GameObject.Find("Portal").transform.position + new Vector3(-1, 0, 0);
        }
        else if(collider.gameObject.name == "Portal3") {  
            gameObject.transform.position = GameObject.Find("Portal4").transform.position + new Vector3(-2, 0, 0);
        }
        else if(collider.gameObject.name == "Portal4") {  
            gameObject.transform.position = GameObject.Find("Portal3").transform.position + new Vector3(2, 0, 0);
        }
   }
}
