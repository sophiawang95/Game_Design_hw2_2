﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSelf : MonoBehaviour {
    float aliveTime = 1;

    // Use this for initialization
    void Start()
    {
        Invoke("DestroySelf", aliveTime);
    }

    // Update is called once per frame
    public void DestroySelf()
    {
        GameObject.Destroy(this.gameObject);
    }

}
