using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatLonConvert : MonoBehaviour {

    public Vector2 LatLonUpLeft;
    public Vector2 LatLonBotRight;
    public Vector2 UnitUpLeft;
    public Vector2 UnitBotRight;

    public float Latitude;
    public float Longitude;
    public float Altitude = 55;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Latitude = HudManager.getInstance().getLatitude();
        Longitude = HudManager.getInstance().getLongitude();

        transform.position = new Vector3(LatLonToUnits().x, Altitude, LatLonToUnits().y);
    }

    Vector2 LatLonToUnits() {
        float zFromLon;
        float xFromLat;

        zFromLon = ((LatLonUpLeft.y - Longitude) / (LatLonUpLeft.y - LatLonBotRight.y)) * (UnitUpLeft.y - UnitBotRight.y) + UnitBotRight.y;
        xFromLat = ((LatLonUpLeft.x - Latitude) / (LatLonUpLeft.x - LatLonBotRight.x)) * (UnitUpLeft.x - UnitBotRight.x) + UnitBotRight.x;

        return new Vector2(zFromLon, xFromLat);
    }
}
