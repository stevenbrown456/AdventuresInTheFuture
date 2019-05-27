using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    
    
   //this is size of inventory
    public GameObject[] inventory = new GameObject[10];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        for (int i = 0; i < inventory.Length; i++)
        {
            if(inventory [i] == null)
            {
                inventory[i] = item;
                Debug.Log(item.name + "was added");
                itemAdded = true;
                //do something  with the object
                item.SendMessage("DoInteraction");
                break;
            }
        }

        //inventory full

        if (!itemAdded)
        {
            Debug.Log("inventory full - item not added ");
        }
    }

	
}
