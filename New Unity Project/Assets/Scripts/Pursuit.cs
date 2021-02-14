using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 2;
         // Move our position a step closer to the target.
        float step = speed  * Time.deltaTime; // calculate distance to move
        
        
        transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Player").transform.position, step);

        // Check if the position of the cube and sphere are approximately equal.
        // if (Vector3.Distance(transform.position, target.position) < 0.001f)
        // {
        //     // Swap the position of the cylinder.
        //     target.position *= -1.0f;
        // }
    }

    //Как найти объект
    //как найти координату
    //Как двигаться в координату
}
