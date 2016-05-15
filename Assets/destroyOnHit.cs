using UnityEngine;
using System.Collections;

public class destroyOnHit : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);//destroys what it hits.
	}
}
