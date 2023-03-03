using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventorySlot
{
    public TemplateContainer container;
    private Button button;
    private Label itemName;
    private ItemObject item;
    public InventorySlot(ItemObject item,VisualTreeAsset template)
    {
        this.item = item;
        //create object
        container = template.Instantiate();
        //get references
        button = container.Q<Button>();
        itemName= container.Q<Label>();
        //assign props
        itemName.text = item.displayName;
        button.text = "";
        button.style.backgroundImage = new StyleBackground(item.sprite);
        //add styles
        container.style.alignItems = Align.Center;
        //add event listeners
        button.RegisterCallback<ClickEvent>(SelectSlot);
    }
    private void SelectSlot(ClickEvent e)
    {
        Debug.Log("You selected " + item.displayName);
    }
}
