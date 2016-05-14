using UnityEngine;
using System.Collections;

public class bunnyController : MonoBehaviour {

	private Rigidbody2D bunny;
	public float bunnyJumpForce = 500.0f;
	// Use this for initialization
	void Start () {
		bunny = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonUp ("Jump")) 
		{
			bunny.AddForce (transform.up*bunnyJumpForce);
		}
	}
}
