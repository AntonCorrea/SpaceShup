using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public float dY;
    public bool startGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        if(startGame == true && transform.position.y > -35)
        {
            transform.position += new Vector3(0f, dY * Time.deltaTime, 0f);
        }
    }
}
