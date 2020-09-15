using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0.02f, 0, 0));
            GetComponent<Animator>().Play("walk_right");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-0.02f, 0, 0));
            GetComponent<Animator>().Play("walk_left");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0.02f, 0));
            GetComponent<Animator>().Play("walk_up");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -0.02f, 0));
            GetComponent<Animator>().Play("walk_down");
        }
        else
        {
            GetComponent<Animator>().Play("idle");
        }
    }
}
