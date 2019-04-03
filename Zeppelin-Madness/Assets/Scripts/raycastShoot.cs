using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycastShoot : MonoBehaviour {

    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public Transform gunEnd;
    public AudioSource gunAudio;
    public GameObject bulletHole;


    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.05f);
    private LineRenderer laserLine;
    private float nextFire;
    private RawImage flash;
    


    void Start () {
        laserLine = GetComponent<LineRenderer>();
        fpsCam = GetComponentInParent<Camera>();
        flash = GameObject.Find("MuzzleFlash").GetComponent<RawImage>();
        bulletHole = Resources.Load("bulletHole") as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Fire1")>0.5 && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            StartCoroutine(ShotEffect());

            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            laserLine.SetPosition(0, gunEnd.position);

            

            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
            {
                laserLine.SetPosition(1, hit.point);
                if (hit.collider.gameObject.tag!= "portal")
                {
                    GameObject clone = Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    Destroy(clone.gameObject, 5);
                }
             
                

                shootableObject health = hit.collider.GetComponent<shootableObject>();
                destroyableObject health2 = hit.collider.GetComponent<destroyableObject>();

                if (health != null)
                {
                    health.Damage(gunDamage);
                }else if (health2 != null)
                {
                    health2.Damage(gunDamage);
                }

                




            }
            else
            {
                laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
           
            }

        }
	}

    private IEnumerator ShotEffect()
    {
        gunAudio.Play();
        flash.enabled = true;
        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
        flash.enabled = false;
    }
}
