using UnityEngine;

public class ballAcelerometer : MonoBehaviour
{
    public float speed = 12f;
    public float deadZone = 0.03f;
    public bool autoCalibrateOnStart = true;

    Rigidbody rb;
    Vector3 calib;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (autoCalibrateOnStart)
            calib = ReadTiltXY();
    }

    Vector3 ReadTiltXY()
    {
        Vector3 acceleration = Input.acceleration;
        return new Vector2(acceleration.x, acceleration.y);
    }

    public void CalibrateNow() => calib = ReadTiltXY();

    void FixedUpdate()
    {
        Vector3 tilt = ReadTiltXY() - calib;

        if (tilt.magnitude < deadZone)
        {
            tilt = Vector2.zero;
        }

        Vector3 force = new Vector3(tilt.x, 0f, tilt.y) * speed;
        rb.AddForce(force, ForceMode.Acceleration);
    }
}
