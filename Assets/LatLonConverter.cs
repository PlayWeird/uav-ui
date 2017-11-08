using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatLonConverter : MonoBehaviour {

    public Vector2 LatLonUpLeft;
    public Vector2 LatLonBotRight;
    public Vector2 UnitUpLeft;
    public Vector2 UnitBotRight;

    public float Latitude;
    public float Longitude;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    Vector2 LatLonToUnits() {
        float xFromLon;
        float zFromLat;

        xFromLon = ((Longitude - LatLonUpLeft.x) / (LatLonBotRight.x - LatLonUpLeft.x)) * (UnitBotRight.x - UnitUpLeft.x) + UnitUpLeft.x;
        zFromLat = ((Longitude - LatLonUpLeft.y) / (LatLonBotRight.y - LatLonUpLeft.y)) * (UnitBotRight.y - UnitUpLeft.y) + UnitUpLeft.y;
        //transform.position	
        
        return new Vector2(xFromLon, zFromLat);
    }
}
