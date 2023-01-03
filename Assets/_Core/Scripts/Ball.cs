using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //the points depending on what the ball touches
    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        switch(tag)
        {
            case "Lose": GameManager.Instance.GameEnd();
                break;
            case "Bumper": break ;
            case "Tunnel": 
                break;
            case "Flipper":
                break;
        }
    }
}
