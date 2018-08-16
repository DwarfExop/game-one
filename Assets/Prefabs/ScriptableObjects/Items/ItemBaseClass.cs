using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Base class where all the in game items inherit from.
public abstract class Item : ScriptableObject {

    //2d icon of the item
    public Sprite artwork;

    /// <summary>
    /// Name of the Item
    /// </summary>
    public string itemName;

    /// <summary>
    /// Description of the item
    /// </summary>
    public string itemDescription;

    //Action that every item has
    protected  virtual void ItemAction()
    {
        Debug.Log(string.Format("{0} is used!", itemName));   
    }
}
