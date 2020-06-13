using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public Health enemyHealth = null;

    int damage = 50;


    void Awake()
    {
        enemyHealth = GameObject.FindGameObjectWithTag("enemy").GetComponent<Health>();
    }


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "enemy")
        {
            enemyHealth.HealthPoints -= damage;
            //  enemyHealth -= damage;

            if (enemyHealth.HealthPoints == 0)
            {
                Destroy(collision.gameObject);
                gameObject.SetActive(false);
            }
        }
    }
}
