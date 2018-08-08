using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MapGenerator mapGen = FindObjectOfType<MapGenerator>();
        mapGen.drawMode = MapGenerator.DrawMode.Mesh;
        mapGen.DrawMapInEditor();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
