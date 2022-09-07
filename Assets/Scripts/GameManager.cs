using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int correctAnswerIndex;
    private int currentQuest = 0;

    public GameObject correctAnswerPanel, wrongAnswerPanel;
    public QuestionController[] questions;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI[] buttonTexts;

    private void Start()
    {
        //SetQuest();
    }
    private void SetQuest()
    {
        int questionIndex = currentQuest % questions.Length;
        questionText.text = questions[questionIndex].questionText;

        for (int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = questions[questionIndex].answers[i];
        }

        correctAnswerIndex = questions[questionIndex].correctAnswerIndex;
        currentQuest++;
    }

    public void AnswerButton(int answerIndex)
    {
        if (answerIndex == correctAnswerIndex)
        {
            correctAnswerPanel.gameObject.SetActive(true);
        }
        else
        {
            wrongAnswerPanel.gameObject.SetActive(true);
        }
    }

    public void PanelButton(bool isTrue)
    {
        if (isTrue)
        {
            correctAnswerPanel.gameObject.SetActive(false);
            SetQuest();
        }
        else
        {
            wrongAnswerPanel.gameObject.SetActive(false);
        }
    }
}
