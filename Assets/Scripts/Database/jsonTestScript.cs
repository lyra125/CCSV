using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class jsonTestScript : MonoBehaviour {

    public int level;
    public float timeElapsed;
    public string playerName;

    jsonTestScript myObject = new jsonTestScript();
    myObject.level = 1;
    myObject.timeElapsed = 47.5f;
    myObject.playerName = "Dr Charles Francis";

    // Use this for initialization
    void Start() {
        string json = JsonUtility.ToJson(myObject);
        myObject = JsonUtility.FromJson<jsonTestScript>(json);
    }

    // Update is called once per frame
    void Update() {

    }
}
