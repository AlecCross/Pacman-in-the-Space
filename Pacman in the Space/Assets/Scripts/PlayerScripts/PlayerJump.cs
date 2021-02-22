using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody _rigidbody;
    GameObject player;
    private void Awake(){
        
    }
    void Start(){
        _rigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {//Попытка присечь подпрыгивание выще двух-трёх прыжков за один раз
        if(player.transform.position.y <= 0.55){
            if(Input.GetKeyDown(KeyCode.Space)){
            _rigidbody.AddForce(Vector3.up * 350f * 0.02f, ForceMode.VelocityChange);
//         rigidbody.AddForce(Vector3.up * 300);
            } 
        }    
    }
}
