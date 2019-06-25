using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnStartGame(int sceneIndex)
    {
        //Application.LoadLevel(sceneName);
        SceneManager.LoadScene(sceneIndex);
    }
}
