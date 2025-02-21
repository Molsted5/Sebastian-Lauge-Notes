using System.Collections;
using UnityEngine;

public class TestCoroutines : MonoBehaviour
{

	public Transform[] path;
	IEnumerator currentMoveCoroutine;
	IEnumerator currentFollowPathCoroutine;

	void Start () {
		string[] messages = { "Welcome", "to", "this", "amazing", "game" };
		StartCoroutine (PrintMessages (messages, .5f));

		currentFollowPathCoroutine = FollowPath();
		StartCoroutine(currentFollowPathCoroutine);
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space)) {

			// Only checks if the reference has been set to begin with
			// Important to understand that a coroutine finishing doesnt set the variable to null!
			// Use isRunning bool if you need to check again and again
			if( currentMoveCoroutine!=null ) { 
				StopCoroutine( currentMoveCoroutine );
			}

			currentMoveCoroutine= Move (Random.onUnitSphere * 5, 8);
			StartCoroutine (currentMoveCoroutine);
		}
	}

	IEnumerator FollowPath() {
		foreach (Transform waypoint in path) {
			currentMoveCoroutine = Move (waypoint.position, 8);
			yield return StartCoroutine (currentMoveCoroutine);
		}
	}

	IEnumerator Move(Vector3 destination, float speed) {
		while (transform.position != destination) {
			transform.position = Vector3.MoveTowards (transform.position, destination, speed * Time.deltaTime);
			yield return null; // wait until next frame
		}
	}

	IEnumerator PrintMessages(string[] messages, float delay) {
		foreach (string msg in messages) {
			print (msg);
			yield return new WaitForSeconds (delay);
		}
	}
}
