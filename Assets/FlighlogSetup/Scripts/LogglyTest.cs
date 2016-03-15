using UnityEngine;
using System.Collections;

public class LogglyTest : MonoBehaviour {

  private string fullCharList = "0123456789abcdefghijklmnopqrstuvwxABCDEFGHIJKLMNOPQRSTUVWXYZ";

  void Start () {
    string code = "";
    for (int i = 0; i < 15; i++) {
      int a = Random.Range(0, fullCharList.Length);
      code += fullCharList[a];
    }
    Debug.Log ("User " + code + " logged in new play session.");
  }
}
