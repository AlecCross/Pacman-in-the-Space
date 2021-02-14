using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int degree = 0;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, degree, transform.rotation.eulerAngles.z);
        if(degree<180)
        degree+=45;
        else
        degree=0;
        
    }
}
