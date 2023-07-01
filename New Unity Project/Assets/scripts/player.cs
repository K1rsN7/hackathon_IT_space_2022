using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 1.0f;
    public FixedJoystick joystick;
    public float velocityRightLeft = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(joystick.Direction.x * Time.deltaTime * velocityRightLeft , 0, velocity * Time.deltaTime);
    }
}
