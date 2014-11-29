using UnityEngine;
using System.Collections;

public class WorldCreator : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		CreateWorld();
	}

	void CreateWorld()
	{
		GameObject worldPrefab = Resources.Load<GameObject>("World");
		GameObject world = Instantiate (worldPrefab) as GameObject;
		
		GameObject dirtPrefab = Resources.Load<GameObject>("Dirt");
		
		Grid worldGrid = world.GetComponent<Grid>();
		
		worldGrid.AddBlock (dirtPrefab, 0,  2 );
		worldGrid.AddBlock (dirtPrefab, 0,  1 );
		worldGrid.AddBlock (dirtPrefab, 1,  1 );

	}
	

}
