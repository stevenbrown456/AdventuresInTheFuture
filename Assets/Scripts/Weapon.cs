using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {


    public Transform firePoint;
    public GameObject laserPrefab;
    private AudioSource audioSource;
    // Update is called once per frame

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            audioSource.Play();
        }
	}
    void Shoot()
    {
        //shooting logic
        Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
    }
}
