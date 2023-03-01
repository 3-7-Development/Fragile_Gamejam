using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class MainMenuTest : MonoBehaviour
{
    private Button playButton;
    private void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        playButton = root.Q<Button>("PlayButton");
        playButton.clicked += () =>
        {
            Debug.Log("Play");
        };
    }
}
