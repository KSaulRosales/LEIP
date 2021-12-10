using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject ScorePanel;

    public Button res1;
    public Button res2;
    public Button res3;
    public Button res4;

    public Text QuestionTxt;
    public Text ScoreTxt;
    public Text MessageTxt;

    int totalQuestions = 0;
    public int score;

    CombatController VidaPlayer;

    public Animator Anim;

    private void Start()
    {
        totalQuestions = QnA.Count;
        ScorePanel.SetActive(false);
        generateQuestion();
    }

    public void Continuar()
    {
        Anim.SetTrigger("Star");
        SceneManager.LoadScene("Creditos");
    }

    void GameOver()
    {
        if (score > 3)
        {
            MessageTxt.text = "Has superado el reto:";
        }
        else
        {
            MessageTxt.text = "Has perdido el reto:";
        }
        ScorePanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
    }

    public void wrong()
    {
        
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());
    }

    public void DesactivateQuestion()
    {
        res1.enabled = false;
        res2.enabled = false;
        res3.enabled = false;
        res4.enabled = false;
    }

    public void ActivateQuestion()
    {
        res1.enabled = true;
        res2.enabled = true;
        res3.enabled = true;
        res4.enabled = true;
    }

    IEnumerator WaitForNext()
    {
        DesactivateQuestion();
        yield return new WaitForSeconds(1);
        QuizPanel.SetActive(false);
        yield return new WaitForSeconds(1);
        QuizPanel.SetActive(true);
        generateQuestion();
        ActivateQuestion();
    }

    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswersScript>().startColor;
            options[i].GetComponent<AnswersScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true;
                
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

                    QuestionTxt.text = QnA[currentQuestion].Question;
                    setAnswers();
        }
        else
        {
            Debug.Log("Fin de las preguntas");
            QuizPanel.SetActive(false);
            GameOver();
        }

    }
}
