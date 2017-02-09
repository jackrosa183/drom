using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
public class ColliderDoor : MonoBehaviour { void OnTriggerEnter (Collider other)
	{ if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Forest"); }
else {

}
}
}