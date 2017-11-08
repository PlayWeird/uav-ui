using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailControl : MonoBehaviour {
    private TrailRenderer myTrail;

	// Use this for initialization
	void Start () {
        myTrail = GetComponent<TrailRenderer>();
        myTrail.enabled = !myTrail.enabled;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void LateUpdate() {
        if (myTrail.enabled == false) {
            myTrail.enabled = !myTrail.enabled;
        }
    }
}
