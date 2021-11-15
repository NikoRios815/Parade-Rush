using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Manager : MonoBehaviour
{
    public static Inventory_Manager instance;
    public Text Item_Amount;

    int Item_Count = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Item_Amount.text = Item_Count.ToString();
    }

    // Update is called once per frame
  public void Add_Item()
    {
       Item_Count += 1;
       Item_Amount.text = Item_Count.ToString();

    }
}
