﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollGround : MonoBehaviour
{
    public float ScrollX = 0.5f;

    // Update is called once per frame
    void Update()
    {
        float OffsetX = Time.time * ScrollX;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0,OffsetX);
    }
}
