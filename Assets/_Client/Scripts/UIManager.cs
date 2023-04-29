using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _exitGameButton;
    
    [Header("Соц. сети")]
    [SerializeField] private Button _vkButton;
    [SerializeField] private Button _telegramButton;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        _startGameButton.onClick.AddListener(() =>
        {
            Loader.OpenLevel(Loader.Level.Game);
        });
        _settingsButton.onClick.AddListener(ShowSettings);
        _exitGameButton.onClick.AddListener(() =>
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#endif
            Application.Quit();
            Debug.Log("Exit...");
        });

        _vkButton.onClick.AddListener(() =>
        {
            Application.OpenURL("https://vk.com/id63475836");
        });
        _telegramButton.onClick.AddListener(() =>
        {
            Application.OpenURL("https://t.me/hahartemida");
        });
    }

    public void ShowSettings()
    {
        Debug.Log("WIP...");
    }
}