using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public string itemName; //Вводим имена в во вкладку Inspector
    private int _score; // счетчик очков

    public Text scoreLabel;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + itemName); // вывод взятого объекта в консоль
        Destroy(this.gameObject);
        if (itemName == "cube")
        {//проверяем, является ли объект здоровьем
            _score++; //увеличиваем счетчик очков
            scoreLabel.text = _score.ToString();
            Debug.Log("Score: " + _score);
        }
    }

    private void Start()
    {
        scoreLabel.text = "0";
    }
}
