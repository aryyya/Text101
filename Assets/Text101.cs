using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text101 : MonoBehaviour
{
    [SerializeField] Text textComponent;

    void Start()
    {
        textComponent.text = "Hello, world!";
    }

    void Update()
    {
    }   
}
