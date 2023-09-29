using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SnakeMover : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;
    [SerializeField] private int _nonCollisionCountTail;
    [SerializeField] private GameObject _scorePanel;
    [SerializeField] private GameObject _menuPanel;

    private void Update()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime);
        //Debug.Log(Input.GetAxis("Horizontal"));

        if(Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(Vector3.down * _speedRotation * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out SnakeTailMove tail))
        {
            if(tail.Index > _nonCollisionCountTail)
            {
                //Debug.Log("Вы проиграли");
                Time.timeScale = 0;
                _scorePanel.SetActive(false);
                _menuPanel.SetActive(true);
            }
        }
    }
}
