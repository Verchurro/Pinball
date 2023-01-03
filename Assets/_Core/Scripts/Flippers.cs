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
    [SerializeField]
    private HingeJoint joint;

    void Start()
    {
       joint = GetComponent<HingeJoint>();
       joint.useSpring = true;

    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitForce;
        spring.damper = flipperDamper;


        
    if(Input.GetAxis(input) == 1)
        {
            spring.targetPosition = pressedPosition;

        }
        else
        {
            spring.targetPosition = baseposition;
        }
    joint.spring = spring;
    joint.useLimits = true;
        
    }
}
