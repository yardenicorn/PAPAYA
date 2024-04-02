using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverPopupController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _yourScore;
    [SerializeField] private TextMeshProUGUI _timeBonus;
    [SerializeField] private TextMeshProUGUI _totalScore;
    [SerializeField] private Button _confirmationButton;
    [SerializeField] private Animator _animator;
    private int _score;
    private int _bonus;
    
    // Start is called before the first frame update
    private void OnEnable()
    {
        _score = GenerateRandomValue();
        _bonus = GenerateRandomValue();
        UpdateField(_score, _yourScore);
        UpdateField(_bonus, _timeBonus);
        CalculateValuesSum();
    }
    
    private int GenerateRandomValue()
    {
        var randomValue = Random.Range(0, 10000);
        return randomValue;
    }
    private void UpdateField (int value, TextMeshProUGUI field)
    {
        field.text = value.ToString();
    }
    private void CalculateValuesSum()
    {
         _totalScore.text = (_score + _bonus).ToString();
    }
    public void OnClickClose()
    {
        _animator.SetTrigger("out");
    }
}
