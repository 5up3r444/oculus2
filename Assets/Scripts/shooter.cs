using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    public float firerate;
    private float nextFire;

    // Update is called once per frame
    void Update()
    {
        if((OVRInput.GetDown(OVRInput.Button.SecondaryTouchpad) || OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad)|| Input.GetKeyDown(KeyCode.I)) && Time.time >nextFire)
        {
            nextFire = Time.time + firerate;
            Instantiate(bullet, gameObject.transform.position + Vector3.forward, gameObject.transform.rotation);
        }
    }
}
