using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow: MonoBehaviour
{
    public Transform target; // The target object to follow
    public Vector3 offset; // The offset of the camera from the target

    void LateUpdate()
    {
        // Check if the target exists
        if (target != null)
        {
            // Set the camera's position to the target's position plus the offset
            transform.position = target.position + offset;
        }
    }
}
