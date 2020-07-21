using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level4stage : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("test5");
        }
        else if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("test3");
        }
    }
}
