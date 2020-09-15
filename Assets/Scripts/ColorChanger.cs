using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public Color charColor;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = charColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
