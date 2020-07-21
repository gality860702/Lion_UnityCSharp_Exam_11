using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class level2card : MonoBehaviour
{
    public Sprite[] itemgroup;
    public Button droll;
    public Image image;

    public void OnMouseUpAsButton()
    {
        GameObject.Find("item").GetComponent<Image>().sprite = itemgroup[Random.Range(1,25)];
    }
}