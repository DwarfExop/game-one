using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelToggler : MonoBehaviour {

    public KeyCode keyCode;
    public List<GameObject> Elements;

    private bool toggled = false;

	void Update ()
    {
        if (Input.GetKeyDown(keyCode) == true)
        {
            toggled = !toggled;
            ToggleInterfaces();
        }

    }

    public void ToggleInterfaces()
    {
        if (toggled)
        {
            foreach (GameObject gameObject in Elements)
            {
                gameObject.GetComponent<CanvasGroup>().alpha = 1;
                gameObject.SetActive(toggled);
            }
        }
        else
        {
            foreach (GameObject gameObject in Elements)
            {
                gameObject.GetComponent<CanvasGroup>().alpha = 0;
                gameObject.SetActive(toggled);
            }
        }

    }

}
