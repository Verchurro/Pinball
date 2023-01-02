using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    [SerializeField]
    private float baseposition = 0f;
    [SerializeField]
    private float pressedPosition = 45f;
    [SerializeField]
    private float hitForce;
    [SerializeField]
    private float flipperDamper = 150f;
    [SerializeField]
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetAxis(input) == 1)
        {

        }
        
    }
}
