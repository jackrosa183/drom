using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
public class ForestDoor : MonoBehaviour { void OnTriggerEnter (Collider other)
	{ if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene ("BedRoom"); }
	else {

	}
}
}