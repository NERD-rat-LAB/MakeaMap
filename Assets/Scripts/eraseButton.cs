﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eraseButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown() {
        transform.parent.GetComponent<ElementScript1>().EraseElement();
    }
}