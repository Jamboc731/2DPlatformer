using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    SphereCollider col;
    GameObject[] spawns;
    public GameObject spikes;

    void Start ()
    {

        col = GetComponent<SphereCollider> ();

    }

    private void OnTriggerEnter (Collider other)
    {

       

        if (other.name.Contains ("Character")) 
        {

            Destroy (this.gameObject);

            spawns = GameObject.FindGameObjectsWithTag ("SpawnPoint");
            //Debug.Log (spawns [1].transform.position);
            foreach(GameObject point in spawns)
            {

                Instantiate (spikes, point.transform.position, new Quaternion());

            }

        }

    }

}
