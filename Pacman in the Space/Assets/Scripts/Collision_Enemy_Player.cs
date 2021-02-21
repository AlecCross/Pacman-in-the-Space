using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Enemy_Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//Удаление объекта срабатывает при запуске игры
        //Destroy(GameObject.Find("Player"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string playerName = "Player";

   void OnTriggerEnter(Collider collider){
       if (collider.gameObject.name == playerName) {  
            Destroy(GameObject.Find(playerName));
        }
   }
    // Теперь метод принимает объект класса Collision, с которым происходит столкновение
        // void OnCollisionEnter(Collision myCollision) {
        //     print("Зашло в метод OnCollisionEnter");
        // // определение столкновения с двумя разноименными объектами
        // if (myCollision.gameObject.name == "Player") {  
        //     Destroy(gameObject);
        // }
    
}

