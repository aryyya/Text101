using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text101 : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    void Update()
    {
    }   
}
