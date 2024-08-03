
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scorTxt;
    public TMP_Text scorTxtEnd;
    public TMP_Text scorTxtEnd_2;
    public int score = 0;
   


    void Update()
    {
        scorTxt.text = score.ToString();
        scorTxtEnd.text = score.ToString();
        scorTxtEnd_2.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }


}
