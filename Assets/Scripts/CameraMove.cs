﻿using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	
	 public Transform target;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		 transform.position = target.position;
	}
}
