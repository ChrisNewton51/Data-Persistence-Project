using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string Name;
    public string CurrentName;
    public int Score;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    public class SaveInfo
    {
        public string Name;
        public int Score;
    }

    public void SaveData()
    {
        SaveInfo data = new SaveInfo();
        data.Name = Name;
        data.Score = Score;
        Debug.Log(data.Name);
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        Debug.Log("load");
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveInfo data = JsonUtility.FromJson<SaveInfo>(json);

            Name = data.Name;
            Score = data.Score;
            Debug.Log(data.Name);
        }
    }
}
