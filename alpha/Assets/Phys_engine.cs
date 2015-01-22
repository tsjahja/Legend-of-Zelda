using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Phys_engine : MonoBehaviour
{
	static public List<Pob> allPobs;

	void Awake()
	{
		allPobs = new List<Pob>();
	}

	void FixedUpdate()
	{
		float dt = Time.fixedDeltaTime;

		// some time stuff?
		foreach(Pob pob in allPobs)
			timeStep(pob, dt);

		// resolve collisions

		// update the position
	}

	public void timeStep(Pob pob, float dt)
	{
		// if still, don't move (set cur and prev pos to whatever Unity reports
		// its position as
		//if(pob.still)
		//{
	//		pob.curPos = pob.prevPos = pob.pushPos = pob.transform.position;
	//		pob.vel = Vector3.zero;
	//		return;
	//	}

		//pob.prevPos = pob.curPos;
		//pob.curPos = pob.transform.position;

		// no velocity or acceleration shenanigans (yet)
	}

	// Use this for initialization
	void Start ()
	{}

	// Update is called once per frame
	void Update ()
	{}
}
