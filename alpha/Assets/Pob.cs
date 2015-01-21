using UnityEngine;
using System.Collections;

public class Pob : MonoBehaviour
{
	public bool still = false;

	public Vector3 prevPos = Vector3.zero;
	public Vector3 curPos = Vector3.zero;
	public Vector3 pushPos = Vector3.zero;

	public Vector3 vel = Vector3.zero;

	// no velocity or accel shenanigans (until projectiles, fuck)

	void resolveCollision(Pob pob)
	{
		// assume it's all walls/blocks this time around
		// if we smack into something, don't keep moving
		this.transform.position = pushPos;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		this.transform.position = pushPos;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		// still things shouldn't move, even if collided with
		if(still)
			return;

		// get the entity we're colliding with
		Pob otherPob = other.GetComponent<Pob>();
		if(otherPob == null)
			return;

		pushPos = prevPos;

		// do some logic
		resolveCollision(otherPob);

		print("trigger");
	}

	void Start()
	{
		// on init, add to the global list of physics objects
		if(Phys_engine.allPobs.IndexOf(this) == -1)
			Phys_engine.allPobs.Add(this);

		prevPos = this.transform.position;
		curPos = this.transform.position;
	}

	// Update is called once per frame
	void Update()
	{}
}
