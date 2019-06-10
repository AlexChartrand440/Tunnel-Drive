using System;
using UnityEngine;

/*
 * @author https://github.com/adamtrinity
 */

public class Shooting : MonoBehaviour
{
    /* Damage variables */
    public float damage = 10f;
    public float range = 100f;
    public int ammo = 100;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    // Update is called once per frame
    void Update()
    {
        //  if (Input.GetButtonDown("space")) {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Console.WriteLine("space was pressed down");
            Debug.Log("Space was pressed downnn");
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Gate target = hit.transform.GetComponent<Gate>();
            if (target != null)
            {

            }
        }
    }
}
