using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    private int _moves;

    private void Start()
    {
        MoreButton.onClick.AddListener(MoreButtonClicked);
        LessButton.onClick.AddListener(LessButtonClicked);
        FinishButton.onClick.AddListener(FinishButtonClicked);


        SetInfoText($"Загадай число от {Min} до {Max}");
        CalculateGuess();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            MoreButtonClicked();
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            LessButtonClicked();
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
        Invoke("End", 2.5f);
    }

    private void End()
    {
        SceneManager.LoadScene("WinScene");
    }

    private void LessButtonClicked()
    {
        Debug.Log(message: "Число меньше");
        Max = _guess;
        _moves++;
        SetMovesLabel($"Количество шагов: {_moves}");
        CalculateGuess();
    }

    private void MoreButtonClicked()
    {
        Debug.Log(message: "Число больше");
        Min = _guess;
        _moves++;
        SetMovesLabel($"Количество шагов: {_moves}");
        CalculateGuess();
    }
}