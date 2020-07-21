using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3stage : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("test4");
        }
        else if (Input.GetKey(KeyCode.O))
        {
            SceneManager.LoadScene("test2");
        }
    }

}
