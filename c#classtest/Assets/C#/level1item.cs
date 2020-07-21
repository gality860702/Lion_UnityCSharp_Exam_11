using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level1item : MonoBehaviour
{
    
    [Header("移動速度"),Range(0,2)]
    public float speed;



    void Update()
    {
       
        transform.Translate(Vector3.left * speed);
    }

   
}
