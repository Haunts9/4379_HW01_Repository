using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHealth;
    int _score = 0;
    TankController _tankController;
    [SerializeField] TextMeshProUGUI _scoreText;
    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
        _scoreText.text = ("Score: " + _score);
    }

    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        Debug.Log("Player Health: " + _currentHealth + " / " + _maxHealth);
    }
    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;
        Debug.Log("Player Health: " + _currentHealth + " / " + _maxHealth);
        if (_currentHealth <= 0)
        {
            Kill();
        }
    }
    public void Kill()
    {
        gameObject.SetActive(false);
        //boom
        //bang
    }

    public void ScoreUp(int value)
    {
        _score+= value;
        if (_scoreText != null)
        {
            _scoreText.text = ("Score: " + _score);
        }

    }

}
