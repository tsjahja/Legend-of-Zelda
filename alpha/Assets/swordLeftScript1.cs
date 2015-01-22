using UnityEngine;
using System.Collections;

public class swordLeftScript1 : MonoBehaviour
{
	public GameObject curHero;
	public GameObject nextHero;

	private int count = 0;

	// Use this for initialization
	void Start()
	{}

	// Update is called once per frame
	void Update()
	{}

	void FixedUpdate()
	{
		if(count < 9)
		{
			++count;
			return;
		}

		Instantiate(nextHero, curHero.transform.position, curHero.transform.rotation);
		Destroy(curHero);
	}
}
