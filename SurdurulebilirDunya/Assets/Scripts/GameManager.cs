using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AnimalEscape.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public GameObject _player;
        private Vector3 pos1, pos2;
        Vector3 konum1, konum2, konum3;
        float swerveSpeed = 20f;
        public List<GameObject> _listChild = new List<GameObject>();
        public bool SwerveSwitch;

        private void Awake()
        {
            if (Instance == null) Instance = this;
        }
        void Update()
        {
            if (SwerveSwitch)
            {
                _player.transform.Translate(0, 0, 3f * Time.deltaTime);
                _player.transform.GetChild(0).GetComponent<Animator>().SetBool("Walk", true);

            }
            SwerveControl(SwerveSwitch, _player);
        }
        public void SwerveControl(bool swerveSwitch, GameObject _player)
        {

            if (Input.GetMouseButtonDown(0) && swerveSwitch)
            {
                pos1 = new Vector2(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);
            }
            if (Input.GetMouseButton(0) && swerveSwitch)
            {
                pos2 = new Vector2(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);

                Vector3 delta = pos1 - pos2;

                _player.transform.position = new Vector3(Mathf.Clamp(_player.transform.position.x, -1.1f, 1.1f), _player.transform.position.y, _player.transform.position.z);

                float swerveValue = delta.x * swerveSpeed * Time.deltaTime;

                _player.transform.Translate(-swerveValue, 0, 0);


            }

        }
    }
}

