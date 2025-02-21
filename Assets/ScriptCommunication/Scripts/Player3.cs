using System;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    public float health = 10;
    public event Action OnPlayerDeath;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 ) {
            // Bad code! 
            // If GameUI is delted, Player3 will not work! 
            //GameObject gameUIObject = GameObject.Find("GameUI");
            //GameUI gameUI = gameUIObject.GetComponent<GameUI>();
            //gameUI.GameOver();

            // Good code! 
            // Player doesnt need know anything about GameUI and it can therefore work without it!
            if (OnPlayerDeath != null ) {
                OnPlayerDeath();
            }
            Destroy(gameObject);
        }
    }
}
