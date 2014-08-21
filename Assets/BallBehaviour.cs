using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public float speed;
	public GameObject ball;
	public Vector3 direction;

	// Use this for initialization
	void Start () {
		//ball.rigidbody.AddForce(direction * 100 * speed);
	}
	
	// Update is called once per frame
	void Update () {
		ball.transform.position += direction * Time.deltaTime * speed;
		//Debug.Log(ball.rigidbody.velocity);
	}

	// Legacy methods - ideally the physics engine will handle reflections
	void OnCollisionEnter (Collision collision) {
		Debug.Log("Collision");
		ContactPoint[] contact = collision.contacts;
		direction = Vector3.Reflect(direction, contact[0].normal);
	}

	Vector3 Bounce (Vector3 reflection) {
		float orix = reflection.x;
		float oriy = reflection.y;
		float oriz = reflection.z;
		return new Vector3(-orix, -oriy, -oriz);
	}
}
