using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cubeの動き
public class Cube : MonoBehaviour {

	Rigidbody cubeRb;

	// Use this for initialization
	void Start () 
	{
		cubeRb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void FixedUpdate ()
	{
		// クリックしたらz軸方向にCubeが飛んでいく
		if (Input.GetButtonDown ("Fire1")) 
		{
			Debug.Log ("Mouse Pressed");
			cubeRb.velocity = new Vector3 (0, 0, 100f);
		}
	}
}
