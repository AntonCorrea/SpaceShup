using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip_1 : MonoBehaviour
{
    public Vector3 startPosition;
    public float deltaX = 1f;
    public float distanceX = 1f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(deltaX * Time.deltaTime, 0f, 0f);
        if(Vector3.Distance(startPosition, transform.position) > distanceX)
        {
            deltaX = -deltaX;
            startPosition = transform.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Player>().TakeDamage( "enemigo");
        }
    }
}
