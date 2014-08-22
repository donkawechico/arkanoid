using UnityEngine;
using System.Collections;

public class BrickBehavior : MonoBehaviour {
	public GameObject Brick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter() {
		Destroy (Brick);
	}

}
