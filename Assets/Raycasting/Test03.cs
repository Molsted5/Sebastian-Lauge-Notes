using UnityEngine;

public class Test03 : MonoBehaviour
{
	void Start() {
		Physics2D.queriesStartInColliders = false; // For some reason in 2D, raycast can and will be default detect the collider it starts in 
	}

	void Update () {

		RaycastHit2D hitInfo = Physics2D.Raycast (transform.position, transform.right, 100);
		if (hitInfo.collider != null) {
			Debug.DrawLine (transform.position, hitInfo.point, Color.red);
		} else {
			Debug.DrawLine (transform.position, transform.position + transform.right * 100, Color.green);
		}
		
	}
}
