using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveboy : MonoBehaviour {
	public float movespeed;
	public float left;
	public float up;
	// Use this for initialization
	void Start () {
			movespeed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		left = 0;
		up = 0;

		if (Input.GetKey("f"))
		{
				left = 1f;
		}
		else if (Input.GetKey("h")){
			left = -1f;
			
		}
		if (Input.GetKey("t"))
		{
				up = 1f;
		}
		else if (Input.GetKey("g")){
			up = -1f;
			
		}
		transform.Translate(movespeed*left*Time.deltaTime,0f,movespeed*up*Time.deltaTime);

	}
}
