using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    public float radius = 2f;//расстояние, с которого можно активировать открытие двери

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {//реакция на кнопку ввода (кнопка E)
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);//метод OverlapSphere возвращает список ближайших объектов    

        }
    }
}
