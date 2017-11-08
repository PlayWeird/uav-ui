using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor; // allows the unity editor .isPlaying to be turned off
#endif



public class GameManager : MonoBehaviour {
    // Create the instance of the GameManager that will be used throught this play
    private static GameManager instance = new GameManager();

    // Function that gives you acess to this instance of GameManager
    public static GameManager getInstance() {
        return instance;
    }

    // Use this for initialization
    void Start () {
        // Reads in config settings at start of play
        ConfigManager.getInstance();
    }
	
	// Update is called once per frame
	void Update () {
        // 
        ROSManager.getInstance().ROSRender();
        
	}

    // Function that returns the current RosManager through the GameManager 
    public ROSManager getROSManager() {
        return ROSManager.getInstance();
    }

    // Function that returns the current ConfigManager throuh the GameManager
    public ConfigManager getConfigManager()
    {
        return ConfigManager.getInstance();
    }

    // Way to quit the game
    public void Quit()
    {
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false; // in editor turn off play mode
        #else
        Application.Quit();// if an application then quit
        #endif
    }


}
