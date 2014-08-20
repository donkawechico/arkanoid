using UnityEngine;
using System.Collections;

public class PaddleBehavior : MonoBehaviour {

	public GameObject Paddle;
	public int Speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) Paddle.transform.Translate (new Vector3(-1,0,0) * Time.deltaTime*Speed);
	    if (Input.GetKey(KeyCode.S)) Paddle.transform.Translate (new Vector3(1,0,0) * Time.deltaTime*Speed);
	    if (Input.GetKey(KeyCode.A)) Paddle.transform.Translate (new Vector3(0,0,-1) * Time.deltaTime*Speed);
	    if (Input.GetKey(KeyCode.D)) Paddle.transform.Translate (new Vector3(0,0,1) * Time.deltaTime*Speed);
	}
}
