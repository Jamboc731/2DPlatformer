using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform target;
    Vector3 toMove = new Vector3 (0, 1f, -10);
    public float speed = 1;
    float startTime;
    float dist;

    void LateUpdate ()
    { 

        transform.position = Vector3.Lerp (transform.position, toMove + target.position, speed);

    }

}
