using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-10000)]
public class FollowCamera : MonoBehaviour
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
