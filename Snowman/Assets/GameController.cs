using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    private WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public UnityEngine.UI.Text GetWordText;
    public UnityEngine.UI.Text GetGuessedLettersText;
    public UnityEngine.UI.Text CheckGuessText;
    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());


        this.Message.text = "Can you save the Snowman?";
        this.StartButton.gameObject.SetActive(false);
        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
    }

    public void OpenStartScreen()
    {
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }

    public void Start()
    {
      this.StartScreen.SetActive(true);
      this.PlayScreen.SetActive(false);  
    }

    public void SubmitGuess()
    {
        string guess = PlayerGuess.text;
        CheckGuessText.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        GetWordText.text = this.guessingGame.GetWord();
        GetGuessedLettersText.text = this.guessingGame.GetGuessedLetters();

        PlayerGuess.text = string.Empty;

        //if this.guessingGame.IsGameOver()
        {

        } //else this.guessingGame.IsGameWon()
        {
            
        }
    }
}
