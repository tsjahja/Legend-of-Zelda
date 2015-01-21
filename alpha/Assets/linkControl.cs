using UnityEngine;
using System.Collections;

public class linkControl : MonoBehaviour
{
	public GameObject hero;
	int face = 0;

	private Animator animator;
	public bool up = false;
	public bool down = false;
	public bool right = false;
	public bool left = false;
	public bool space = false;

	void moveKeys()
	{
		// THIS IS UGLY CODE BUT IT SERVERS A (POSSIBLY) IMPORTANT PURPOSE
		if (Input.GetKey ("right")
			&&
						!Input.GetKey ("left")
			&&
						!Input.GetKey ("down")
			&&
						!Input.GetKey ("up")) {
						face = 0;
						animator.SetBool ("right", true);
						animator.SetBool ("left", false);
						animator.SetBool ("up", false);
						animator.SetBool ("down", false);
						hero.transform.position += new Vector3 (.01f, 0, 0);
				} else if (Input.GetKey ("left")
			&&
						!Input.GetKey ("right")
			&&
						!Input.GetKey ("up")
			&&
						!Input.GetKey ("down")) {
						face = 1;
						animator.SetBool ("right", false);
						animator.SetBool ("left", true);
						animator.SetBool ("up", false);
						animator.SetBool ("down", false);
						;
						hero.transform.position += new Vector3 (-.01f, 0, 0);
				} else if (Input.GetKey ("up")
			&&
						!Input.GetKey ("right")
			&&
						!Input.GetKey ("left")
			&&
						!Input.GetKey ("down")) {
						face = 2;
						animator.SetBool ("right", false);
						animator.SetBool ("left", false);
						animator.SetBool ("up", true);
						animator.SetBool ("down", false);
						hero.transform.position += new Vector3 (0, .01f, 0);
				} else if (Input.GetKey ("down")
			&&
						!Input.GetKey ("right")
			&&
						!Input.GetKey ("left")
			&&
						!Input.GetKey ("up")) {
						face = 3;
						animator.SetBool ("right", false);
						animator.SetBool ("left", false);
						animator.SetBool ("up", false);
						animator.SetBool ("down", true);
						hero.transform.position += new Vector3 (0, -.01f, 0);
				} else if (Input.GetKey ("right")
			&&
						Input.GetKey ("up")
			&&
						!Input.GetKey ("left")
			&&
						!Input.GetKey ("down")) {
						if (face == 0) {
								hero.transform.position += new Vector3 (0, .01f, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", false);
								animator.SetBool ("up", true);
								animator.SetBool ("down", false);
			
						} else if (face == 2) {
								hero.transform.position += new Vector3 (.01f, 0, 0);
								animator.SetBool ("right", true);
								animator.SetBool ("left", false);
								animator.SetBool ("up", false);
								animator.SetBool ("down", false);
						}
				} else if (Input.GetKey ("left")
			&&
						Input.GetKey ("up")
			&&
						!Input.GetKey ("right")
			&&
						!Input.GetKey ("down")) {
						if (face == 1) {
								hero.transform.position += new Vector3 (0, .01f, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", false);
								animator.SetBool ("up", true);
								animator.SetBool ("down", false);
			
						} else if (face == 2) {
								hero.transform.position += new Vector3 (-.01f, 0, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", true);
								animator.SetBool ("up", false);
								animator.SetBool ("down", false);
						}
				} else if (Input.GetKey ("right")
			&&
						Input.GetKey ("down")
			&&
						!Input.GetKey ("left")
			&&
						!Input.GetKey ("up")) {
						if (face == 0) {
								hero.transform.position += new Vector3 (0, -.01f, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", false);
								animator.SetBool ("up", false);
								animator.SetBool ("down", true);

						} else if (face == 3) {
								hero.transform.position += new Vector3 (.01f, 0, 0);
								animator.SetBool ("right", true);
								animator.SetBool ("left", false);
								animator.SetBool ("up", false);
								animator.SetBool ("down", false);
						}
				} else if (Input.GetKey ("left")
			&&
						Input.GetKey ("down")
			&&
						!Input.GetKey ("right")
			&&
						!Input.GetKey ("up")) {
						if (face == 1) {
								hero.transform.position += new Vector3 (0, -.01f, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", false);
								animator.SetBool ("up", false);
								animator.SetBool ("down", true);
			

						} else if (face == 3) {
								hero.transform.position += new Vector3 (-.01f, 0, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", true);
								animator.SetBool ("up", false);
								animator.SetBool ("down", false);
						}
				} else if (Input.GetKey ("left")
			&&
						Input.GetKey ("right")
			&&
						!Input.GetKey ("down")
			&&
						!Input.GetKey ("up")) {
						if (face == 0) {
								hero.transform.position += new Vector3 (-.01f, 0, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", true);
								animator.SetBool ("up", false);
								animator.SetBool ("down", false);
			
						} else if (face == 1) {
								hero.transform.position += new Vector3 (.01f, 0, 0);
								animator.SetBool ("right", true);
								animator.SetBool ("left", false);
								animator.SetBool ("up", false);
								animator.SetBool ("down", false);
						}
				} else if (Input.GetKey ("up")
			&&
						Input.GetKey ("down")
			&&
						!Input.GetKey ("right")
			&&
						!Input.GetKey ("left")) {
						if (face == 2) {
								hero.transform.position += new Vector3 (0, -.01f, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", false);
								animator.SetBool ("up", false);
								animator.SetBool ("down", true);
			

						} else if (face == 3) {
								hero.transform.position += new Vector3 (0, .01f, 0);
								animator.SetBool ("right", false);
								animator.SetBool ("left", false);
								animator.SetBool ("up", true);
								animator.SetBool ("down", false);
						}

				// stand, no button is pressed
		} else if (!Input.GetKey ("up")
		           &&
		           !Input.GetKey ("down")
		           &&
		           !Input.GetKey ("right")
		           &&
		           !Input.GetKey ("left")
		           &&
		           !Input.GetKey("space")) {
					animator.SetBool ("right", false);
					animator.SetBool ("left", false);
					animator.SetBool ("up", false);
					animator.SetBool ("down", false);
					animator.SetBool("space", false);
					
		} else if (!Input.GetKey ("up")
		           &&
		           !Input.GetKey ("down")
		           &&
		           !Input.GetKey ("right")
		           &&
		           !Input.GetKey ("left")
		           &&
		           Input.GetKey("space")) {
					animator.SetBool("space", true);
		}
	}
	
	void Awake() {
		animator = GetComponent<Animator>();
	}

	void Start()
	{}

	void Update() {
		if (Input.GetButtonDown ("space")) {
			print ("space pressed");
			//animation.Play("linkswordleft");//, PlayMode.StopAll);
			
		}
	}

	void FixedUpdate()
	{
		moveKeys();

	}
}

