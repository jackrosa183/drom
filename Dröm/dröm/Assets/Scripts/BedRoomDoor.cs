using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
public class BedRoomDoor : MonoBehaviour { void OnTriggerEnter (Collider other)
	{ if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene (4); }
	else {

	}
}
}