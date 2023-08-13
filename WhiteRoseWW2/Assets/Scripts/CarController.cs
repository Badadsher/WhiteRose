using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    WheelJoint2D[] wheelJoints;
    JointMotor2D frontWheel;
    JointMotor2D backWheel;

    private float deceleration = -400f;
    private float gravity = -9.8f;
    private float angleCar = 0;
    private float acceleration = 500f;
    private float maxSpeed = -800f;
    public float maxBackSpeed = 600f;
    public float brakeForce = 1000f;
    public float wheelSize;
    public bool grounded = false;
    public LayerMask Ground;
    public Transform bWheel;

    void Start()
    {
        wheelJoints = gameObject.GetComponents<WheelJoint2D>();
        frontWheel = wheelJoints[0].motor;
        backWheel = wheelJoints[1].motor;
    }


    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(bWheel.transform.position, wheelSize, Ground);
        angleCar = transform.localEulerAngles.z;
        if (angleCar > 180) angleCar = angleCar - 360;
        if (grounded)
        {
                backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (acceleration - gravity * Mathf.PI * (angleCar / 180) * 80) * Input.GetAxis("Horizontal") * Time.deltaTime, maxSpeed, maxBackSpeed);
        }
        if (Input.GetAxis("Horizontal") < 0 && backWheel.motorSpeed < 0)
            backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deceleration - gravity * Mathf.PI * (angleCar / 180) * 80) * Time.deltaTime, maxSpeed, maxBackSpeed);
        if (Input.GetAxis("Horizontal") < 0 && backWheel.motorSpeed > 0)
            backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deceleration - gravity * Mathf.PI * (angleCar / 180) * 80) * Time.deltaTime, maxSpeed, maxBackSpeed);
        backWheel = frontWheel;

        wheelJoints[0].motor = backWheel;
        wheelJoints[1].motor = frontWheel;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(bWheel.transform.position, wheelSize);
    }
}
 