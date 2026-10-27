using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GamePauseUI : MonoBehaviour
{
    [SerializeField] private GameObject visual;

    [SerializeField] private Button resumeButton;
    [SerializeField] private Button mainMenuButton;

    private bool isPaused = false;

    private void Awake()
    {
        
        resumeButton.onClick.AddListener(Resume);

        mainMenuButton.onClick.AddListener(() =>
        {
            Time.timeScale = 1f;
            Loader.Load(Loader.Scene.MainMenu);
        });
    }

    private void Start()
    {
        Hide();
    }

    private void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    private void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;
        Show();
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1f;
        Hide();
    }

    private void Show()
    {
        if (visual != null)
        {
            visual.SetActive(true);
        }
    }

    private void Hide()
    {
        if (visual != null)
        {
            visual.SetActive(false);
        }
    }
}