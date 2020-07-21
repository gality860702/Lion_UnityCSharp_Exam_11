using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class level1stagechange: MonoBehaviour
{
     void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("test2");
        }
        if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("test5");
        }
    }
}
