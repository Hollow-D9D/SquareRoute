using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BaseGameUi : MonoBehaviour
{
   [SerializeField] private Button pause;
   [SerializeField] private Button exit;
   [SerializeField] private Button restart;
   [SerializeField] private Button resume;
   [SerializeField] private GameObject pausePanel;

   private void Start()
   {
      pause.onClick.AddListener(Pause);
      exit.onClick.AddListener(Exit);
      restart.onClick.AddListener(Restart);
      resume.onClick.AddListener(Resume);
   }

   private void Resume()
   {
      Time.timeScale = 1;
      pausePanel.SetActive(false);
   }

   private void Restart()
   {
      Time.timeScale = 1;
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   private void Exit()
   {
      Time.timeScale = 1;
      SceneManager.LoadScene("Start");
   }

   private void Pause()
   {
      Time.timeScale = 0;
      pausePanel.SetActive(true);
   }
}
