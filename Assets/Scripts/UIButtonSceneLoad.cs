using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonSceneLoad : MonoBehaviour {

    public void loadScene (string Scane) {
        SceneManager.LoadScene (Scane);
    }
}