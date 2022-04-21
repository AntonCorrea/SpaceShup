using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movCoef = 0.1f;
    public GameObject bullet;
    public float bulletPos;
    private CharacterController characterController;
    public GameObject explosion;
    public Animator animator;
    public GameManager gameManager;

    void Start() 
    { 
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        characterController.Move(newPosition * movCoef * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject newBullet = GameObject.Instantiate(bullet);
        newBullet.transform.position = transform.position + new Vector3(0f,bulletPos,0f);
    }

    public void TakeDamage(string from)
    {
        Debug.Log("Te ha golpeado un " + from);
        GameObject newExplosion = GameObject.Instantiate(explosion);
        newExplosion.transform.position = transform.position;

        gameObject.SetActive(false);
        gameManager.GameOver();
    }

    public void DisableAnimator()
    {
        animator.enabled = false;
    }
    
}
