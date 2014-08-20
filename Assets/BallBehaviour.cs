using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public float speed;
	public GameObject ball;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		ball.rigidbody.AddForce(direction * 100);
	}
	
	// Update is called once per frame
	void Update () {
		//ball.transform.position += direction * Time.deltaTime * speed;
		Debug.Log(ball.rigidbody.velocity);
	}

	void OnCollision (Collision collision) {
		Debug.Log("Collision");
		direction = Bounce(direction);
	}

	Vector3 Bounce (Vector3 reflection) {
		float orix = reflection.x;
		float oriy = reflection.y;
		float oriz = reflection.z;
		return new Vector3(-orix, -oriy, -oriz);
	}
}
