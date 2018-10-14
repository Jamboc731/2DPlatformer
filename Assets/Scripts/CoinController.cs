using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    SphereCollider col;
    GameObject[] spawns;
    GameObject [] toDestroy;
    public GameObject spikes;
    public GameObject openChest;
    public Transform closedChest;
    Vector3 chestPos;


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
            foreach (GameObject point in spawns)
            {

                Instantiate (spikes, point.transform.position, new Quaternion ());

            }

        }

        toDestroy = GameObject.FindGameObjectsWithTag ("ToDestroy");

        foreach (GameObject obj in toDestroy)
        {

            Destroy (obj);

        }

        chestPos = closedChest.position;

        Destroy (closedChest.gameObject);

        Instantiate (openChest, chestPos, new Quaternion ());

    }

}
