﻿using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	public bool isFiring;

	public BulletController bullet;
	public float shootSpeed;

	public float timeBetweenShots;
	private float shotCounter;

	public Transform firePoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isFiring) 
		{
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0) 
			{
				shotCounter = timeBetweenShots;
				BulletController newBullet = Instantiate (bullet, firePoint.position, firePoint.rotation) as BulletController;
				newBullet.bulletSpeed = shootSpeed;
			}
		} else 
		{
			shotCounter = 0;
		}
	
	}
}
