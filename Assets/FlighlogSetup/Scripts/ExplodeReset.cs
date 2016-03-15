using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExplodeReset : MonoBehaviour {

  public GameObject explosion;
  public GameObject crashText;

	void OnCollisionEnter (Collision collider) {
	   if(collider.gameObject.tag == "Player" && Time.time > 3f)
     {
       Instantiate(explosion, collider.gameObject.transform.position, collider.gameObject.transform.rotation);
       Debug.Log("Player Died: Collision");
       StartCoroutine(WaitCoroutine());
     }
	}

  public IEnumerator WaitCoroutine()
  {
    crashText.SetActive(true);
    yield return new WaitForSeconds(2);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
