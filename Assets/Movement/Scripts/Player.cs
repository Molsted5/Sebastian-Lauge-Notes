using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 10;

	void Update () {
		Vector3 input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		Vector3 direction = input.normalized;
		Vector3 velocity = direction * speed;
		Vector3 moveAmount = velocity * Time.deltaTime;

		//transform.position += moveAmount; // world space 
		//transform.localPosition += moveAmount; // local space
		transform.Translate(moveAmount); // Space.Self (default) or Space.World
	}
}
