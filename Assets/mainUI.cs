using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainUI : MonoBehaviour
{
    [SerializeField]
    Text text;
    [SerializeField]
    Image image;
    void Start()
    {
        text.text = "Hello World";
        image.fillAmount = 0;
    }
    void Update()
    {
        image.fillAmount += Time.deltaTime / 10;
    }
}
