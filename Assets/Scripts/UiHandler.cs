using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiHandler : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI text;
    public TextMeshProUGUI instructions;
    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;

    public GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
    }
    void Update()
    {
        if (GlobalVars.hasStarted)
        {
            text.text = GlobalVars.score.ToString();
            instructions.text = "";
        }
        if (GlobalVars.gameOver) {
            panel.SetActive(true);
            score.text = GlobalVars.score.ToString();
            highScore.text = GlobalVars.highScore.ToString();
        }
    }
}
