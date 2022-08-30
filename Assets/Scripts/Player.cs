using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
[RequireComponent(typeof(TankController))]
public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 3;
    int _currentHealth;

    TankController _tankController;

    private void Awake()
    {
        _tankController = GetComponent<TankController>();
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth,0,_maxHealth);
        Debug.Log("Player Health: " + _currentHealth + " / " + _maxHealth);
    }
    public void DecreaseHealth(int amount)
    {
        _currentHealth -= amount;
        Debug.Log("Player Health: " + _currentHealth + " / " + _maxHealth);
        if(_currentHealth <= 0)
        {
            Kill();
        }
    }
    public void Kill()
    {
        gameObject.SetActive(false);
        //boom
        //bang
=======
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
>>>>>>> main
    }
}
