using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private TrailRenderer _trail;

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.TryGetComponent(out SnakeMover snake))
        {
            gameObject.SetActive(false);
            _trail.enabled = false;
        }
    }

    private void OnEnable()
    {
        _trail.enabled = true;
        _trail.Clear();
    }
}

//-Сделать след
//-Сделать снег
