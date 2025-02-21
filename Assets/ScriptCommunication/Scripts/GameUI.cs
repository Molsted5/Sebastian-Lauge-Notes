using UnityEngine;

public class GameUI : MonoBehaviour
{
    Player3 player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject playerObject = GameObject.Find("Player");
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        player = playerObject.GetComponent<Player3>();

        player.OnPlayerDeath += GameOver;
    }

    // Update is called once per frame
    void Update()
    {
        DrawHealthBar(player.health);
    }

    void DrawHealthBar(float playerHealth ) {
        // Implementation
    }

    public void GameOver() {
        // Wrte "Game Over" on screen
    }
}
