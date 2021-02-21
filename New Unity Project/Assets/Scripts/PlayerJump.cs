using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody rigidbody;
    private void Awake(){
        rigidbody = GetComponent<Rigidbody>();
        GameObject player = GameObject.Find("Player");
    }

    void Update()
    {//Попытка присечь подпрыгивание выще двух-трёх прыжков за один раз
        if(GameObject.Find("Player").transform.position.y <= 0.55){
            if(Input.GetKeyDown(KeyCode.Space)){
            rigidbody.AddForce(Vector3.up * 350f * 0.02f, ForceMode.VelocityChange);
//         rigidbody.AddForce(Vector3.up * 300);
            } 
        }    
    }
}
