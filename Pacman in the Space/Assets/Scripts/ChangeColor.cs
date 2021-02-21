using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour{
    public Material[] mar_s;
    public void OnMouseDown(){
        gameObject.GetComponent<Renderer>().material = mar_s[Random.Range(0, mar_s.Length)];
    }

}
