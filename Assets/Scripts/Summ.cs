using TMPro;
using UnityEngine;

public class Summ : MonoBehaviour
{
    public TextMeshProUGUI InfoLabel;
    public TextMeshProUGUI SumLabel;
    public TextMeshProUGUI MovesLabel;

    private int _sum;
    private int _moves;
    public int Sum;

    void Start()
    {
        SetInfoText($"Жми цифры от 1 до 9 чтобы их суммировать. Тебе нужно достигнуть числа {Sum}");
    }

    void Update()
    {
        if (_sum < Sum)
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
        else if (_sum == Sum)
        {
            MovesText($"Количество шагов: {_moves}");
            SetInfoText($"Победа! Число {Sum} достигнуто! Игра окончена.\nДля повторной игры нажми клавишу пробел");
        }
        else if (_sum > Sum)
        {
            MovesText($"Количество шагов: {_moves}");
            SetInfoText($"Ты проиграл! Твое число {_sum} больше {Sum}.\nДля повторной игры нажми клавишу пробел");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _moves = 0;
            _sum = 0;
            MovesText(" ");
            GetSummText(" ");
            Start();
        }
    }

    private void CalculateSum(int num)
    {
        _sum += num;
        _moves++;
        GetSummText($"Сумма: {_sum}");
    }

    private void SetInfoText(string text)
    {
        Debug.Log(text);
        InfoLabel.text = text;
    }

    private void GetSummText(string text)
    {
        Debug.Log(text);
        SumLabel.text = text;
    }

    private void MovesText(string text)
    {
        Debug.Log(text);
        MovesLabel.text = text;
    }
}