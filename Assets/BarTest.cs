using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarTest : MonoBehaviour {

    public Slider healthBar;

    [Range(0,200)]
    public float CurrentValue = 100;
    public float MaxValue = 100;
    public string Represents;
    private float maxSize;
    private Text text;

    private void Start()
    {
        healthBar.value = CalculateHealth();
        text = healthBar.GetComponentInChildren<Text>(true);
    }
    // Update is called once per frame
    void Update () {
        healthBar.value = CalculateHealth();
        text.text = string.Format("{0}: {1} / {2}",Represents,CurrentValue,MaxValue);
	}

    float CalculateHealth()
    {
        return CurrentValue / MaxValue;
    }

}
