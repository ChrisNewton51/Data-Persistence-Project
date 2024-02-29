using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI bestScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bestScore.text = "Best Score: " + GameManager.Instance.Name + ": " + GameManager.Instance.Score;
    }
}
