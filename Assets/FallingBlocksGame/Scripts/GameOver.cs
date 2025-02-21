using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
	public GameObject gameOverScreen;
	public TextMeshProUGUI secondsSurvivedUI;
	bool gameOver;

	void Start() {
		GameObject playerObject = GameObject.Find("Player");
		PlayerController playerController = playerObject.GetComponent<PlayerController>();
		playerController.OnPlayerDeath += OnGameOver;
	}

	void Update () {
		if (gameOver) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (0);
			}
		}
	}

	void OnGameOver() {
		gameOverScreen.SetActive (true);
		secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
		gameOver = true;
	}
}
