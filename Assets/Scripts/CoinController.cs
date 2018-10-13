using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    SphereCollider col;

    void Start ()
    {

        col = GetComponent<SphereCollider> ();

    }

    private void OnTriggerEnter (Collider other)
    {

       

        if (other.name.Contains ("Player")) 
        {

            Destroy (this.gameObject);

        }

    }

}
