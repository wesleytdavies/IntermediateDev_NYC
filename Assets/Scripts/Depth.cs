﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(transform.position.y);
    }
}
