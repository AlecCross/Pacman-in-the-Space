using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    //срабатывает один раз при запуске скрипта
    {
        
    }

    // Update is called once per frame
    void Update()//обновление 30 раз(кадров) в секунду
    //частота срабатываний зависит от кол-ва кадров на устр-ве
    {
        //проверка нажатия кнопки пробел
        if (Input.GetKey(KeyCode.Space))
        {
            print("Space button is pressed");
        }
    }
    [SerializeField]
    public float charSpeed = 5f;
    public float turnSpeed = 50f;

    void FixedUpdate()
    //фиксированная частота срабатываний
    {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.JoystickButton19))
            transform.Translate(Vector3.forward*charSpeed*Time.deltaTime);
        if (Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.JoystickButton18))
            transform.Translate(Vector3.back*charSpeed*Time.deltaTime);
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.JoystickButton17))
            transform.Translate(Vector3.left*charSpeed*Time.deltaTime);
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.JoystickButton16))
            transform.Translate(Vector3.right*charSpeed*Time.deltaTime);
    //Vector3 это значит что точка находится в 3х мерном пространстве
    }
}
