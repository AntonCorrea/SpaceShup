using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string gameState;
    public GameObject player;
    public GameObject map;
    public GameObject mainMenu;
    public GameObject gameOverAlert;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        mainMenu.gameObject.SetActive(false);
        map.GetComponent<Map>().startGame = true;
        player.GetComponent<Player>().animator.enabled = true;
    }

    public void GameOver()
    {
        gameOverAlert.SetActive(true);
    }
}
