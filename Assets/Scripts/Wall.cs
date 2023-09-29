using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private GameObject _scorePanel;
    [SerializeField] private GameObject _menu;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out SnakeMover snake))
        {
            Time.timeScale = 0;
            _scorePanel.SetActive(false);
            _menu.SetActive(true);
            //Debug.Log("1");
        }
    }
}
