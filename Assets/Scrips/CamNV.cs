using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamNV : MonoBehaviour
{
    public Transform tr;
    public Vector3 off;
    [Range(1, 10)]
    public float sm;
    private void FixedUpdate()
    {
        Follow();
    }
    void Follow()
    {
        Vector3 targetPosition = tr.position + off;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, sm*Time.fixedDeltaTime);
        transform.position = targetPosition;
    }
}
