using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObject : MonoBehaviour {

    public float distance;
    public float smooth;
    public float range;

    private Camera fpsCam;
    private bool carrying;
    private GameObject carriedObject;
	
	void Start () {
        fpsCam = GetComponentInParent<Camera>();
       
    }
	
	// Update is called once per frame
	void Update () {
        if (carrying)
        {
            carry(carriedObject);
            checkDrop();
        }else {
            pickup();
        }
	}

    private void carry(GameObject o)
    {
        if (o!=null)
        {
            o.transform.position = Vector3.Lerp(o.transform.position, fpsCam.transform.position + fpsCam.transform.forward * distance, Time.deltaTime * smooth);
        }

    }

    private void pickup()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = fpsCam.ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, range))
            {
                pickableObject p = hit.collider.GetComponent<pickableObject>();
                if (p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }

        }
    }

    private void checkDrop()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            dropObject();
        }
    }

    private void dropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        carriedObject = null;
    }
}
