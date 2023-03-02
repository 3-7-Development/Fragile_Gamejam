using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InGameView : View
{
<<<<<<< HEAD
    [SerializeField] private VisualTreeAsset inventoryTemplate;
    [SerializeField] private VisualTreeAsset inventorySlotTemplate;
    [SerializeField] private List<ItemObject> inventoryContent;
    private Button playButton;
    private Button buildButton;


    protected override void OnEnable()
    {
        base.OnEnable();
        //przyciski zmiany trybu
        InitializeModeButtons();

        //ekwipunek
        InitializeInventory();
    }
    private void InitializeModeButtons()
    {
=======
    private Button playButton;
    private Button buildButton;

    protected override void OnEnable()
    {
        base.OnEnable();
>>>>>>> 889ff3f (...)
        playButton = document.rootVisualElement.Q<Button>("PlayButton");
        buildButton = document.rootVisualElement.Q<Button>("BuildButton");

        playButton.clicked += PlayMode;
        buildButton.clicked += BuildMode;
    }
<<<<<<< HEAD
    private void InitializeInventory()
    {
        if (inventoryContent.Count > 0)
        {
            Inventory inv = new Inventory(inventoryContent, inventorySlotTemplate, inventoryTemplate);
            document.rootVisualElement.Add(inv.inventory);
        }
    }
=======
>>>>>>> 889ff3f (...)
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
<<<<<<< HEAD
    //zmiana klas przycisków
    private void SelectClass(Button selected, Button unselected)
    {
        selected.RemoveFromClassList("unselected");
        selected.AddToClassList("selected");

        unselected.RemoveFromClassList("selected");
        unselected.AddToClassList("unselected");
=======
    private void SelectClass(Button selected, Button unselected)
    {
        selected.RemoveFromClassList("button");
        selected.AddToClassList("selected");

        unselected.RemoveFromClassList("selected");
        unselected.AddToClassList("button");
>>>>>>> 889ff3f (...)
    }
}
