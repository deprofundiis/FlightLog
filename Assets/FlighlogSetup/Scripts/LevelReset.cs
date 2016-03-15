using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelReset :MonoBehaviour
{
    private void Restart()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
