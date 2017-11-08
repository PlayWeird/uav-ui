using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudManager : MonoBehaviour {
    private static HudManager instance = new HudManager();

    public float Latitude, Longitude, Altitude;
    
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        Latitude = ROSManager.getInstance().getLatitude();
        Longitude = ROSManager.getInstance().getLongitude();
        Altitude = ROSManager.getInstance().getAltitude();

        instance.setLatitude(Latitude);
        instance.setLongitude(Longitude);
        instance.setAltitude(Altitude);
    }

    public static HudManager getInstance() {
        return instance;
    }

    public float getLatitude() {
        return Latitude;
    }

    public void setLatitude(float latitude) {
        Latitude = latitude;
    }

    public float getLongitude() {
        return Longitude;
    }

    public void setLongitude(float longitude) {
        Longitude = longitude;
    }

    public float getAltitude() {
        return Altitude;
    }

    public void setAltitude(float altitude) {
        Altitude = altitude;
    }
}
