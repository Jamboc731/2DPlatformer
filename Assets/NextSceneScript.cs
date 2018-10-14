using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneScript : MonoBehaviour {

    private void OnTriggerEnter (Collider other)
    {

        if (other.gameObject.name.Contains ("Character"))
        {

            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

        }

    }

}
