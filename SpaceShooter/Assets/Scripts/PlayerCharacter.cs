using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int _health = 500;
    private int maxHealth = 1000;

    public void Hurt(int damage)
    {
        _health -= damage;//уменьшение здоровья игрока
        Debug.Log("Health: " + _health);
    }
}