using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability: ScriptableObject {

    public string abilityName;
    public string abilityDescription;

    public float cooldown;

    protected virtual void AbilityAction()
    {
        Debug.Log(string.Format("Ability: {0} was used",abilityName));
    }

}
