using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.SceneManagement;


public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI inputName;
    public TextMeshProUGUI bestScoreText;
    void Start()
    {
        GameManager.Instance.LoadData();
        bestScoreText.SetText("Best Score: " + GameManager.Instance.Name + ": " + GameManager.Instance.Score);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    private void SetName(string name)
    {
        GameManager.Instance.CurrentName = name;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        SetName(inputName.text);
        GameManager.Instance.SaveData();
    }

}
