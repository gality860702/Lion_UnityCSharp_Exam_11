using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level5stage : MonoBehaviour
{
    void Update()
    {
       
       if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("test4");
        }
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("test1");
        }
    }
}
