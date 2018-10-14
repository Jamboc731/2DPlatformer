using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HazardController : MonoBehaviour {

    void OnTriggerEnter (Collider other)
    {

        if (other.gameObject.name.Contains ("Character"))
        {
            
            SceneManager.LoadScene (SceneManager.GetActiveScene ().name.ToString ());

        }

    }

}
