using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float dY;
    public float destroyAfter;
    public GameObject explosionParticle;

    void Start()
    {
        Destroy(gameObject, destroyAfter);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, dY * Time.deltaTime, 0f);        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(gameObject);
            other.GetComponent<Destructable>().Destroy();

            GameObject newPartcile = GameObject.Instantiate(explosionParticle);
            newPartcile.transform.position = other.transform.position;
        }
    }
}
