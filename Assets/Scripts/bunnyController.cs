using UnityEngine;
using System.Collections;

public class bunnyController : MonoBehaviour {

	private Rigidbody2D bunny;
	public float bunnyJumpForce = 500.0f;
	private Animator myAnim;
	// Use this for initialization
	void Start () {
		bunny = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonUp ("Jump")) 
		{
			
			bunny.AddForce (transform.up*bunnyJumpForce);
		}

		myAnim.SetFloat ("vVelocity", Mathf.Abs(bunny.velocity.y));
	}
}
