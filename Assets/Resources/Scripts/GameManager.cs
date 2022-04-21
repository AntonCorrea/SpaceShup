using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject map;
    public GameObject mainMenu;
    public GameObject messageAlert;
    public GameObject nextButton;

    public void StartGame()
    {
        mainMenu.gameObject.SetActive(false);
        map.GetComponent<Map>().startGame = true;
        player.GetComponent<Player>().animator.enabled = true;
    }

    public void GameOver(string msg)
    {
        messageAlert.SetActive(true);
        messageAlert.GetComponent<MessageAlert>().SetText(msg);

        if(msg == "Stage Clear")
        {
            player.GetComponent<Animator>().enabled = true;
            player.GetComponent<Animator>().Play("PlayerTakeOffAnimation");
            nextButton.SetActive(true);
        }
    }

    public void NextMap()
    {

    }
}
