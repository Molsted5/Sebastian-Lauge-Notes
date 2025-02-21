using UnityEngine;

public class CubeScript : MonoBehaviour
{
	public Transform sphereTransform;

	// Use this for initialization
	void Start () {
		sphereTransform.parent = transform;
		sphereTransform.localScale = Vector3.one * 2;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate around global y axis
		//transform.eulerAngles += new Vector3(0, 180 * Time.deltaTime, 0);
		//transform.eulerAngles += new Vector3(0, 1, 0) * 180 * Time.deltaTime; // Shorthand Vector3.up

		// Rotate around global or local y axis
		// Note that local space is object space of parrent if it has one
		transform.Rotate (Vector3.up * Time.deltaTime * 180, Space.World); // Space.Self for local (default)
		transform.Translate (Vector3.forward * Time.deltaTime * 7, Space.World);

		if (Input.GetKeyDown (KeyCode.Space)) {
			sphereTransform.localPosition = Vector3.zero;
		}
	}
}
