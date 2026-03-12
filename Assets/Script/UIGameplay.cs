using UnityEngine;
using UnityEngine.UI;

public class UIGameplay : MonoBehaviour
{
    public int sceneIndex;
    public Button buttonResume;
    public Button buttonPause;
    public Button buttonMenu;
    
    void Start()
    {
        buttonMenu.onClick.AddListener(() => GameManager.Instance.ChangeScene(sceneIndex));
        buttonPause.onClick.AddListener(() => GameManager.Instance.Pause());
        buttonResume.onClick.AddListener(() => GameManager.Instance.Resume());
    }
}