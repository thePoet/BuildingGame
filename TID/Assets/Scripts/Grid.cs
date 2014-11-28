using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{


	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void AddBlock( GameObject blockPrefab, int x, int y )
	{
		GameObject block = Instantiate (blockPrefab) as GameObject;
		
		block.transform.parent = transform;
		block.transform.localPosition = new Vector3 (x, y, 0);
		
		//Block blockScript = block.GetComponent<Block>();
		//blockScript.xGrid = x;
		//blockScript.yGrid = y;
	}
}
