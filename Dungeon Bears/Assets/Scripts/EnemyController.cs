using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	private Rigidbody enemyRB;
	public float moveSpeed;

	public PlayerController thePlayer;

	// Use this for initialization
	void Start () {
		enemyRB = GetComponent<Rigidbody> ();
		thePlayer = FindObjectOfType<PlayerController> ();


	
	}

	void FixedUpdate () {
		enemyRB.velocity = (transform.forward * moveSpeed);
	}
	// Update is called once per frame
	void Update () {
		//Look at the player
		transform.LookAt(thePlayer.transform.position);
	
	}
}
