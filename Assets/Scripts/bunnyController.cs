using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bunnyController : MonoBehaviour {

	private Rigidbody2D bunny;
	public float bunnyJumpForce = 500.0f;
	private Animator myAnim;
	private float bunnyHurtTime = -1f;
	private Collider2D myCollider;
	public Text scoreText;
	private float startTime;
	// Use this for initialization

	void Start () {
		bunny = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();
		myCollider = GetComponent<Collider2D> ();
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (bunnyHurtTime == -1f) 
		{
			if ((Input.touchCount >0 ) || (Input.GetButtonUp("Jump"))) {
			
				bunny.AddForce (transform.up * bunnyJumpForce);
			}

			myAnim.SetFloat ("vVelocity", bunny.velocity.y);
			scoreText.text = (Time.time - startTime).ToString ("0.0");
		} 
		else 
		{
			if (Time.time > bunnyHurtTime + 2)
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
		{
			
			foreach (moveLeft movelefter in FindObjectsOfType<moveLeft>()) 
			{
				movelefter.enabled = false;
			}

			foreach (prefabSpawner spawner in FindObjectsOfType<prefabSpawner>()) 
			{
				spawner.enabled = false;
			}

			bunnyHurtTime = Time.time;
			myAnim.SetBool ("bunnyHurt", true);
			bunny.velocity = Vector2.zero;
			bunny.AddForce (transform.up * bunnyJumpForce);
			myCollider.enabled = false;
		}
		
	}
}
