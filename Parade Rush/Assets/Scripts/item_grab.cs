using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_grab : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D Collider)
    {

        if (Collider.gameObject.tag == "Player")
        {
            Inventory_Manager.instance.Add_Item();
            Destroy(gameObject);
        }
    }
}
