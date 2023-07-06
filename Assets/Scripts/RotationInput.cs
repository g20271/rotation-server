using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationInput : MonoBehaviour
{

    Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        rot = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = rot;
    }

    public void ReceiveW(float w) {
        rot.w = w;
    }
    public void ReceiveX(float x) {
        rot.x = x;
    }
    public void ReceiveY(float y) {
        rot.y = y;
    }
    public void ReceiveZ(float z) {
        rot.z = z;
    }
}
