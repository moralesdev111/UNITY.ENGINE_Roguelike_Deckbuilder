using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button playGameButton;
    [SerializeField] SceneLoader sceneLoader;


    void Start()
    {
        playGameButton.onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        sceneLoader.ChangeScene(sceneLoader.sceneIndex);
    }
}
