using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelReset :MonoBehaviour
{
    public void Restart(){
      Application.LoadLevel(0);
    }


    private void Update()
    {
    }
}
