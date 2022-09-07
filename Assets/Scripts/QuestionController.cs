using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "QuestionController")]
public class QuestionController : ScriptableObject
{
    public string questionText;
    public string[] answers;
    public int correctAnswerIndex;
}
