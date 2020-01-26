using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagManager : MonoBehaviour
{
	Flag[] flagsInLevel;
	float flagsToWin;
	public string nextLevel;
	//Global Variables^
    // Start is called before the first frame update
    void Start()
    {
        flagsInLevel = FindObjectsOfType<Flag>();
        flagsToWin = flagsInLevel.Length;   
    }

    // Update is called once per frame
    void Update()
    {
     if (CheckFlags() == true) {
     	SceneManager.LoadScene(nextLevel);
     	}   
    }

    bool CheckFlags() {
    	bool result = true;
    	foreach (Flag f in flagsInLevel) {
			if (f.captured == false) {
    			result = false;
    		}
    	}
    	return result;
    }
}
