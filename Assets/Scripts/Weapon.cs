﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject laserPrefab;

    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Fire1"))
        {

            if (Input.GetButtonDown("Fire1"))
            {


                Shoot();
            }
        }
        void Shoot()
        {
            //shooting logic
            Instantiate(laserPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
