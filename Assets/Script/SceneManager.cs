using UnityEngine;
using UnityEngine.UI;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

public class SceneManager : MonoBehaviour
{
    private Button buttonMenu;
    private Button buttonPause;
    private Button buttonResume;
    
    private GameObject pausePanel;

    private void Start()
    {
        buttonMenu.onClick.AddListener(() => GameManager.Instance.ChangeScene(0)); // MenuScene index
        buttonPause.onClick.AddListener(() => GameManager.Instance.Pause());
        buttonResume.onClick.AddListener(() => GameManager.Instance.Resume());
        
        if (pausePanel != null)
        {
            buttonResume.onClick.AddListener(() => pausePanel.SetActive(false));
            buttonPause.onClick.AddListener(() => pausePanel.SetActive(true));
        }
    }
}