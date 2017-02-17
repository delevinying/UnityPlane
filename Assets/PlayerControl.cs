﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.position += new Vector3 (0.1f, 0, 0);
		}else if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.position += new Vector3 (0, 0.1f, 0);
		}else if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.position += new Vector3 (-0.1f, 0, 0);
		}
	}
}
