using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private TMP_Text scoreText;

    private int score;
    private float timer; // Cambiar a float
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    void Update()
    {
        UpdateScore();
    }

    public void ShowGameOverScreen()
    {
        // Mostrar la pantalla de Game Over
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f; // Pausar el juego
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; // Restaurar el tiempo del juego
    }

    private void UpdateScore()
    {
        int scorePerSecond = 5;
        timer += Time.deltaTime; // Incrementar el timer correctamente
        score = (int)(timer * scorePerSecond);
        scoreText.text = string.Format("{0:00000}", score);
    }
}

