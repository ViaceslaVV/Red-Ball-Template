using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] TMP_Text bestTimeText;
    public static GameManager instance;
    public float levelTime;
    float bestTime;

    void Awake()
    {
        instance = this;
        bestTime = PlayerPrefs.GetFloat("bestTime", float.MaxValue);
        bestTimeText.text = "Best:" + TimeSpan.FromSeconds(bestTime).ToString(@"mm\:ss\:f");
    }

    void Update()
    {
        levelTime += Time.deltaTime;
        timerText.text = TimeSpan.FromSeconds(levelTime).ToString(@"mm\:ss\:f");
    }

    public void Win()
    {
        if (levelTime < bestTime)
        {
            bestTime = levelTime;
            PlayerPrefs.SetFloat("bestTime", bestTime);
        }
    }

    public async void Die()
    {
        await new WaitForSeconds(2f);
        var name = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name);
    }
}
