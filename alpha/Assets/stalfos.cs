using UnityEngine;
using System.Collections;

public class stalfos : MonoBehaviour {

	public GameObject enemy;
	private float speed = 0.25f;
	private bool direction = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if (direction) pos.x += speed * Time.deltaTime;
		else pos.y += speed * Time.deltaTime;
		transform.position = pos;

	}

	void FixedUpdate() {

		if (Random.value < 0.01f && Random.value >= 0.005f) {
			speed *= -1;
		} else if (Random.value < 0.005f) {
			if(direction) direction = false;
			else direction = true;
		}
	}
}
