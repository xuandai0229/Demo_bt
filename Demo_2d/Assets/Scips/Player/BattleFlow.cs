using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public PlayerHealth playerHealth;
    public GameObject bgAudio;

    private void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerHealth.onDead += OnGameOver; //dung su kien onDead de goi ham OnGameOver khi player chet
    }
    private void Update()
    {
        if(EnemyHealth.livingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    void OnGameOver()
    {
        gameOverUI.SetActive(true);
        bgAudio.SetActive(false); //tat am thanh nen khi game over
    }

    void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgAudio.SetActive(false); //tat am thanh nen khi chien thang
        playerHealth.gameObject.SetActive(false); //an player khi chien thang
    }

    public void ReturnToMainMenu() => SceneManager.LoadScene("MainMenu");

}
