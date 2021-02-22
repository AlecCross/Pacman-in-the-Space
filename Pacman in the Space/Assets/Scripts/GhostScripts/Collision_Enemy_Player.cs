using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision_Enemy_Player : MonoBehaviour{
    string playerName = "Player";
    public Text _endGame; 
    

    void OnCollisionEnter(Collision collider){
       if (collider.gameObject.name == playerName){ 
            GameObject.Find(playerName).SetActive(false);
             _endGame.text = "Game Over";
           print(playerName+"Убит!");
       }
   }
}

