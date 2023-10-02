using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextRun : MonoBehaviour
{

    [SerializeField] private float typingSpeed = 0.1f;
    [SerializeField] private TextMeshProUGUI textMeshPro;

   // [SerializeField] private string textToType;


    [SerializeField] private TextMeshProUGUI printedText;
    [SerializeField] private string startString;
    private void Start()
    {
        printedText.text = "";

        StartCoroutine(PrintText(startString));
    }

    private IEnumerator PrintText(string str)
    {
        foreach (char letter in str)
        {
            printedText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    /* private void Start()
     {
         textToType = textMeshPro.text;
         textMeshPro.text = "";
         StartCoroutine(TypeText());
     }

     IEnumerator TypeText()
     {
         foreach (char c in textToType)
         {
             textMeshPro.text += c;
             yield return new WaitForSeconds(typingSpeed);
         }
     }

     public void SetTypingSpeed(float speed)
     {
         typingSpeed = speed;
     }
    */
}