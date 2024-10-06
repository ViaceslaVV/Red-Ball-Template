using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float speed;
    public Transform target;

    void LateUpdate()
    {
        var TARGETPOS = target.position;
        TARGETPOS.z = -10;

        transform.position = Vector3.Lerp(transform.position, TARGETPOS, speed * Time.deltaTime);
    }
}
