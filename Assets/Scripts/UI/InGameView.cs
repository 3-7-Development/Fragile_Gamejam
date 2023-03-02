using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InGameView : View
{
    private Button playButton;
    private Button buildButton;

    protected override void OnEnable()
    {
        base.OnEnable();
        playButton = document.rootVisualElement.Q<Button>("PlayButton");
        buildButton = document.rootVisualElement.Q<Button>("BuildButton");

        playButton.clicked += PlayMode;
        buildButton.clicked += BuildMode;
    }
    private void PlayMode()
    {
        LevelManager.Instance.spawning= true;
        SelectClass(playButton, buildButton);
    }
    private void BuildMode()
    {
        LevelManager.Instance.spawning = false;
        SelectClass(buildButton, playButton);
        LevelManager.Instance.ClearPlayers();
    }
    private void SelectClass(Button selected, Button unselected)
    {
        selected.RemoveFromClassList("unselected");
        selected.AddToClassList("selected");

        unselected.RemoveFromClassList("selected");
        unselected.AddToClassList("unselected");
    }
}
