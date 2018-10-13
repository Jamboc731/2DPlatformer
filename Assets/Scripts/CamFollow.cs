using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform target;
    Vector3 toMove = new Vector3(0, 6, -10);

    void LateUpdate ()
    {

        toMove.x = target.position.x;
        transform.position = toMove;

    }

}
