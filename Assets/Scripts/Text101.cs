using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text101 : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    private State state;
    private static readonly KeyCode[] keyCodes = {
        KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3
    };
        
    private void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    private void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (var i = 0; i < nextStates.Length && i < keyCodes.Length; i++)
        {
            if (Input.GetKeyDown(keyCodes[i]))
            {
                state = nextStates[i];
                textComponent.text = state.GetStateStory();
                break;
            }
        }
    }
}
