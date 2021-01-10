using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalStateManager : MonoBehaviour {
    public List<GameObject> Players = new List<GameObject> ();

    private int deadPlayers = 0;
    private int deadPlayerNumber = -1;

    public void PlayerDied (int playerNumber) {
        deadPlayers++;

        if (deadPlayers == 1) {
            deadPlayerNumber = playerNumber;
            Invoke ("CheckPlayersDeath", .3f);
        }
    }

    void CheckPlayersDeath () {
        if (deadPlayers == 1) {

            if (deadPlayerNumber == 1) {
                Debug.Log ("Player 2 is the winner!");
                SceneManager.LoadScene ("GameOver 2");
            } else {
                Debug.Log ("Player 1 is the winner!");
                SceneManager.LoadScene ("GameOver 1");
            }
        } else {
            Debug.Log ("The game ended in a draw!");
        }
    }
}