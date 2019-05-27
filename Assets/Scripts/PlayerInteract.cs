using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

   public GameObject currentInterObj = null;
   public Key currentInterObjScript = null;
   public Inventory inventory;

     void Update()
    {
        if(Input.GetButtonDown("Interact") &&currentInterObj)
        {
            //check to see if this object is stored in inventory
            if (currentInterObjScript.inventory)
            {
                inventory.AddItem(currentInterObj);
            }


           
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            Debug.Log("other.name");
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<Key>();

        }
    }

     void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            if(other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            
            

        }
    }
}
