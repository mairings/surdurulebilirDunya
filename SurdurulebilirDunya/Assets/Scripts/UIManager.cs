using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AnimalEscape.Manager
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _score;
        [SerializeField] GameObject _tutorial;
        private void Update()
        {
            _score.text = PlayerPrefs.GetInt("saveAnimals").ToString();

            if (Input.GetMouseButtonDown(0))
            {
                _tutorial.SetActive(false);
                GameManager.Instance.SwerveSwitch = true;
            }

        }
    }
}

