using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class barDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        int currentscene = SceneManager.GetActiveScene().buildIndex;
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(currentscene + 1);
        }
        else
        {

        }
    }
}