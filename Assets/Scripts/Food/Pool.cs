using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pool : MonoBehaviour
{
    [SerializeField] private int _capacity;
    [SerializeField] private Transform _container;

    private List<Food> _pool = new List<Food>();

    protected void Init(Food template)
    {
        for(int i = 0; i < _capacity; i++)
        {
            CreateObject(template);
        }
    }

    protected Food GetFreeElement()
    {
        if (HasFreeElement(out Food freeElement))
        {
            return freeElement;
        }
        return null;
    }

    private void CreateObject(Food template)
    {
        Food _obdj = Instantiate(template, _container);
        _obdj.gameObject.SetActive(false);
        _pool.Add(_obdj);
    }

    private bool HasFreeElement(out Food element)
    {
        element = null;
        for(var i = 0; i < _pool.Count; i++)
        {
            if(_pool[i].gameObject.activeSelf == false)
            {
                element = _pool[i];
                return true;
            }
        }
        return false;
    }
}


//Порядок полей
//Сериализованные
//Паблик
//Протектед
//Приват
//Свойства


//Порядок методов
//Юнити методы
//Паблик методы
//Протектед методы
//Приват методы
