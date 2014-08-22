using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 ballPosition = ball.transform.position;
		Camera.main.transform.eulerAngles = new Vector3(Mathf.Clamp(-ballPosition.x, -16, 16), 270, 0);
	}
}
