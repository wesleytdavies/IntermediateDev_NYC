using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private int time = 0;
    private int frameTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameTime++;
        if(frameTime >= 60)
        {
            time++;
            frameTime = 0;
        }
        GetComponent<TextMeshProUGUI>().text = "Time: " + time.ToString();
    }
}
