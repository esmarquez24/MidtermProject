using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameOver : MonoBehaviour
{
    CursorLockMode _prevLock;
    bool _prevVisible;
    void RestoreCursor()
    {
        Cursor.lockState = _prevLock;
        Cursor.visible = _prevVisible;
    }
    public void OnPlayAgainButton()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
