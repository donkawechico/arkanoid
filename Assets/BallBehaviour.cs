using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public float speed;
	public GameObject ball;
	public Vector3 direction;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ball.transform.position += direction * Time.deltaTime * speed;
		//Debug.Log(ball.rigidbody.velocity);
	}

	void OnCollisionEnter (Collision collision) {
		Debug.Log("Collision");
		ContactPoint[] contact = collision.contacts;
		direction = Vector3.Reflect(direction, contact[0].normal);
	}
}
