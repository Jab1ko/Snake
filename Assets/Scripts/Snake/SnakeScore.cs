using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SnakeScore : MonoBehaviour
{
    public event UnityAction Eated;
    public int Score { get; private set; }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.TryGetComponent(out Food food))
        {
            Score++;
            Eated?.Invoke();
        }
    }
}
