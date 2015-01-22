using UnityEngine;
using System.Collections;

public enum CollType
{
	INERT,
	ENEMY,
	PLAYER,
	SWORD
};

public class Pob : MonoBehaviour
{
	public CollType ct;

	public Vector3 prevPos = Vector3.zero;
	public Vector3 curPos = Vector3.zero;
	public Vector3 pushPos = Vector3.zero;

	public GameObject obj;

	public Vector3 vel = Vector3.zero;

	private bool pushIt;

	// no velocity or accel shenanigans (until projectiles, fuck)

	void resolveCollision(Pob pob)
	{
		// if we smack into something, don't keep moving
		if(this.ct == CollType.PLAYER)
		{
			if(pob.ct == CollType.INERT)
				pushIt = true;

			else if(pob.ct == CollType.ENEMY)
				// damage player stuff

			return;
		}

		if(this.ct == CollType.ENEMY)
		{
			if(pob.ct == CollType.SWORD)
				Destroy(obj);
		}

		else
			return;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		Pob otherPob = other.GetComponent<Pob>();

		if(this.ct == CollType.PLAYER && otherPob.ct == CollType.INERT)
			pushIt = true;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		pushIt = false;

		// get the entity we're colliding with
		Pob otherPob = other.GetComponent<Pob>();
		if(otherPob == null)
			return;

		pushPos = prevPos;

		// do some logic
		resolveCollision(otherPob);
	}

	void timeStep()
	{
		if(this.ct == CollType.INERT)
		{
			curPos = prevPos = pushPos = this.transform.position;
			return;
		}

		prevPos = curPos;
		curPos = this.transform.position;
	}

	void Start()
	{
		prevPos = this.transform.position;
		curPos = this.transform.position;
	}

	void Update()
	{
		if(pushIt)
			this.transform.position = pushPos;

		pushIt = false;

		timeStep();

	}
}
