using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRootScript : MonoBehaviour {
    public PlayerC realplayer;
    // Use this for initialization
    void Start () {
		
	}
    public void Hit(float value)
    {
        realplayer.Hit(5);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
