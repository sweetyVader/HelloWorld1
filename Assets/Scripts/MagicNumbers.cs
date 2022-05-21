using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    public int Min;
    public int Max;

    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI GuessLabel;
    public TextMeshProUGUI MovesLabel;
    public Button MoreButton;
    public Button LessButton;
    public Button FinishButton;

    private int _guess;
    private int _moves = 0;
    private int _min;
    private int _max;
    private bool _isEnd = true;

    void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);
        _min = Min;
        _max = Max;
        SetInfoText($"Загадай число от {Min} до {Max}");
        CalculateGuess();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Min = _min;
            Max = _max;
            _guess = (Min + Max) / 2;
            _moves = 0;
            _isEnd = true;
            SetInfoText($"Загадай число от {Min} до {Max}");
            SetMovesLabel(" ");
            CalculateGuess();
        }
    }

    private void CalculateGuess()
    {
        _guess = (Min + Max) / 2;
        SetGuessLabel($"Твое число {_guess}?");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }

    private void SetGuessLabel(string text)
    {
        Debug.Log(text);
        GuessLabel.text = text;
    }

    private void SetMovesLabel(string text)
    {
        Debug.Log(text);
        MovesLabel.text = text;
    }
    private void FinishButtonClicked()
    {
        Debug.Log(message: "Победа");
        SetGuessLabel($"Победа! Твое число: {_guess}");
        SetMovesLabel($"Количество шагов: {_moves}");
        _isEnd = false;
    }

    private void LessButtonClicked()
    {
        if (_isEnd)
        {
            Debug.Log(message: "Число меньше");
            Max = _guess;
            _moves++; 
            CalculateGuess();
        }
    }

    private void MoreButtonClicked()
    {
        if (_isEnd)
        {
            Debug.Log(message: "Число больше");
            Min = _guess;
            _moves++;
            CalculateGuess();
        }
    }
}