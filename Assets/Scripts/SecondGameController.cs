using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SecondScene" , menuName ="Questionnaire" ) ]
public class SecondGameController : ScriptableObject
{
    [System.Serializable]
    public struct QuestionHolder
    {
        [TextArea]
        public string question;

        public string[] options;

        public int correctIndex;
    }
}
