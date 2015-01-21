using UnityEngine;
using System.Collections;

public class camRes : MonoBehaviour {

	// Use this for initialization
	void Start()
	{}

	// Update is called once per frame
	void Update()
	{
		UnityEngine.Camera.main.orthographicSize = 240f * Screen.height / Screen.width * 0.5f;
	}
}
