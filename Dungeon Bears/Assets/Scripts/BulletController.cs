using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float bulletSpeed;
	public float lifeTime;
	public int damageToGive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * bulletSpeed * Time.deltaTime);
		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0) 
		{
			Destroy (gameObject);
		}

	
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damageToGive);
			Destroy (gameObject);
		}
	}
}
