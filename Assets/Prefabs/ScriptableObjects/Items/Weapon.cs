using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Weapon",menuName ="Items/Weapon")]
public class Weapon : Item {
    [System.Serializable]
    public enum WeaponType { Magic, Melee, Ranged};
    public WeaponType style;
    public int type;
    public int damage;
    [Range(0,100)]
    public float critChance;

    protected override void ItemAction()
    {

    }
}
