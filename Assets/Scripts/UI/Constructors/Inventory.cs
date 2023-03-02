using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory
{
    public VisualElement inventory;
    public Inventory(List<ItemObject> inventoryContent, VisualTreeAsset inventorySlotTemplate, VisualTreeAsset inventoryTemplate)
    {
        TemplateContainer inventoryContainer = inventoryTemplate.Instantiate();
        inventory = inventoryContainer.Q("Inventory");
        VisualElement itemsRow = inventory.Q("ItemsRow");
        //itemsRow.AddToClassList("backgroundColor");
        Color bgColor = new Color(0.07f, 0.45f, 0.33f);
        itemsRow.style.backgroundColor = bgColor;
        foreach (ItemObject item in inventoryContent)
        {
            InventorySlot slot = new InventorySlot(item, inventorySlotTemplate);
            itemsRow.Add(slot.container);
        }
    }
}
