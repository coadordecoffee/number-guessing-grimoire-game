using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    //Debug.Log("MY NAME IS GRIMOIRE NUMBER AND IT IS NOT TO BE ABBREVIATED");
    //Debug.Log("Bwah hah hah! I am Grimoire Number! My very name brings kingdoms to their knees! I am a genius!");

    // Variables
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start(){
        StartGame();
    }

    void StartGame(){
        NextGuess(); 
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }  

    void NextGuess(){
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
