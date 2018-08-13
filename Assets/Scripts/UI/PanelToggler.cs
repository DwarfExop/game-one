using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggler : MonoBehaviour {

    public KeyCode keyCode;
    public List<GameObject> Elements;

    private bool toggled = false;

	void Update () {
        if (Input.GetKeyDown(keyCode) == true)
        {
            ToggleInterfaces();
        }

    }
    public void ToggleInterfaces()
    {
        toggled = toggled ? false : true;
        foreach (GameObject gameObject in Elements)
        {
            gameObject.SetActive(toggled);
        }
    }
}
