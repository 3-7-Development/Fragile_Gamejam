using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory
{
    public VisualElement inventory;
    public Inventory(InventoryObject inventoryContent, VisualTreeAsset inventoryTemplate, VisualTreeAsset inventorySlotTemplate )
    {
        TemplateContainer inventoryContainer = inventoryTemplate.Instantiate();
        inventory = inventoryContainer.Q("Inventory");
        VisualElement itemsRow = inventory.Q("ItemsRow");
        //itemsRow.AddToClassList("backgroundColor");
        Color bgColor = new Color(0.07f, 0.45f, 0.33f);
        itemsRow.style.backgroundColor = bgColor;
        foreach (InventorySlot item in inventoryContent.content)
        {
            InventorySlotComponent slot = new InventorySlotComponent(item, inventorySlotTemplate);
            itemsRow.Add(slot.container);
        }
    }
}

public class InventorySlotComponent
{
    public TemplateContainer container;
    private Button button;
    private Label itemName;
    private ItemObject item;
    private int amount;
    public InventorySlotComponent(InventorySlot slot, VisualTreeAsset template)
    {
        this.item = slot.item;
        this.amount = slot.amount;
        //create object
        container = template.Instantiate();
        //get references
        button = container.Q<Button>();
        itemName = container.Q<Label>();
        //assign props
        itemName.text = item.displayName;
        button.text = amount.ToString();
        button.style.backgroundImage = new StyleBackground(item.sprite);
        //add event listeners
        button.RegisterCallback<ClickEvent>(SelectSlot);
    }
    private void SelectSlot(ClickEvent e)
    {
        Debug.Log("You selected " + item.displayName);
        GridManager.Instance.SelectObcject(item.prefab.gameObject);
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;
    public InventorySlot(ItemObject item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }
}
