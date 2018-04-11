using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public LineRenderer targetLine;
    public GameObject laser;
    public float bulletSpeed = 40;

    void TargetLineAdjuster()
    {
        targetLine.SetPosition(0, transform.position);
        targetLine.SetPosition(1, transform.position + transform.forward * 10);
    }

    

    void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(laser, transform.position + transform.forward * 1, transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * (bulletSpeed * Time.deltaTime),ForceMode.Impulse);
            Destroy(newBullet, 5);
        }
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        TargetLineAdjuster();
    }
}
