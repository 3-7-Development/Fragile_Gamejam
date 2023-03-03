using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InGameView : View
{
    [SerializeField] private VisualTreeAsset inventoryTemplate;
    [SerializeField] private VisualTreeAsset inventorySlotTemplate;
    [SerializeField] private InventoryObject inventoryObject;
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
        playButton = document.rootVisualElement.Q<Button>("PlayButton");
        buildButton = document.rootVisualElement.Q<Button>("BuildButton");

        playButton.clicked += PlayMode;
        buildButton.clicked += BuildMode;
    }
    private void InitializeInventory()
    {
        if (inventoryObject.content.Count > 0)
        {
            Inventory inv = new Inventory(inventoryObject, inventoryTemplate, inventorySlotTemplate);
            document.rootVisualElement.Add(inv.inventory);
            TemplateContainer inventoryContainer = inventoryTemplate.Instantiate();
            VisualElement inventory = inventoryContainer.Q("Inventory");
            VisualElement itemsRow = inventory.Q("ItemsRow");
            itemsRow.style.backgroundColor = new Color(20, 117, 87);
            foreach (ItemObject item in inventoryContent)
            {
                InventorySlot slot = new InventorySlot(item, inventorySlotTemplate);
                itemsRow.Add(slot.container);
            }
            document.rootVisualElement.Add(inventory);
        }
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
    //zmiana klas przycisk�w
    private void SelectClass(Button selected, Button unselected)
    {
        selected.RemoveFromClassList("unselected");
        selected.AddToClassList("selected");

        unselected.RemoveFromClassList("selected");
        unselected.AddToClassList("unselected");
    }
}
