using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip_2 : MonoBehaviour
{
    public float dY;
    public bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            transform.position += new Vector3(0f, dY * Time.deltaTime, 0f);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BoundingBox_U")
        {
            start = true;
        }
    }
}
