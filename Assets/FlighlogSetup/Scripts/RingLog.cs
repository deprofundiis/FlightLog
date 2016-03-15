using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RingLog : MonoBehaviour {

  private string scoreText = "#Rings: ";
  private Text uiTextComponent;
  private ScoreKeeper scoreScript;

  void Start(){
    uiTextComponent = GameObject.Find("Score").GetComponent<Text>();
    scoreScript = GameObject.FindWithTag("GameController").GetComponent<ScoreKeeper>();
  }

	// Plane goes through Ring
	void OnTriggerEnter (Collider other) {
    if(other.gameObject.name == "BodyCentreCapsule"){
		  Debug.Log("Passed through: " + gameObject.name);
      scoreScript.score++;
      uiTextComponent.text = scoreText + scoreScript.score.ToString();
      Debug.Log("Score updated: " + uiTextComponent.text);
    }
	}
}
