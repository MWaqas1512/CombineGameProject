using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    float bulletSpeed = 3100;
    public GameObject Bullet;
    AudioSource bulletAudio;

    void Start()
    {
        bulletAudio = GetComponent<AudioSource>();
    }

    void Fire()
    {
        //shoot
        GameObject tempBullet = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
        Rigidbody tempRigidBodyBullet = tempBullet.GetComponent<Rigidbody>();
        tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
        Destroy(tempBullet, 3f);

        //play audio
        bulletAudio.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }
}
