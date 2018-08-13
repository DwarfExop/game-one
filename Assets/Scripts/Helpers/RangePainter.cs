using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangePainter : MonoBehaviour {

    public Color color = Color.yellow;
    public float radius = 5f;
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
