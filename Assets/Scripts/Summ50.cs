using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Summ50 : MonoBehaviour
{
    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI SummLabel;
    public TextMeshProUGUI MovesLabel;

    private int _summ;
    private int _moves;
    public int Summ;

    void Start()
    {
        SetInfoText($"Жми цифры от 1 до 9 чтобы их суммировать. Тебе нужно достигнуть числа {Summ}");
    }

    void Update()
    {
        if (_summ < Summ)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                CalculateSum(1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                CalculateSum(2);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                CalculateSum(3);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                CalculateSum(4);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                CalculateSum(5);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                CalculateSum(6);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                CalculateSum(7);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                CalculateSum(8);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                CalculateSum(9);
            }
        }
        else if (_summ == Summ)
        {
            MovesText($"Количество шагов: {_moves}");
            SetInfoText($"Победа! Число {Summ} достигнуто! Игра окончена.\nДля повторной игры нажми клавишу пробел");
        }
        else if (_summ > Summ)
        {
            MovesText($"Количество шагов: {_moves}");
            SetInfoText($"Ты проиграл! Твое число {_summ} больше {Summ}.\nДля повторной игры нажми клавишу пробел");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _moves = 0;
            _summ = 0;
            MovesText(" ");
            GetSummText(" ");
            Start();
        }
    }
    private void CalculateSum(int num)
    {
        _summ += num;
        _moves++;
        GetSummText($"Сумма: {_summ}");
    }
    private void SetInfoText(string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }
    private void GetSummText(string text)
    {
        Debug.Log(text);
        SummLabel.text = text;
    }
    private void MovesText(string text)
    {
        Debug.Log(text);
        MovesLabel.text = text;
    }
}