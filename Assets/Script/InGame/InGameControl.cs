using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame
{
    public class InGameControl : MonoBehaviour
    {

        public GameObject TopViewPlayer;
        public GameObject SideViewPlayer;
        public GameObject pause_menu;
        public GameObject Theater;
        public CameraControl camera;

        private float character_speed;

        // Start is called before the first frame update
        void Start()
        {
            character_speed = 0;
        }

        private void Update()
        {

            // toggle pause menu
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause_menu.SetActive(!pause_menu.activeSelf);
            }

            if (Input.GetKeyDown(KeyCode.U))
            {
                camera.is_side_view = !camera.is_side_view;
                Theater.SetActive(!Theater.activeSelf);
            }
            TopViewPlayer.transform.position += new Vector3(character_speed * 3, 0, 0) * Time.deltaTime;
            SideViewPlayer.transform.position += new Vector3(character_speed * 3, 0, 0) * Time.deltaTime;

            TopViewPlayer.GetComponent<Animator>().SetFloat("speed", character_speed);
            SideViewPlayer.GetComponent<Animator>().SetFloat("speed", character_speed);
        }

        // Update is called once per frame
        void FixedUpdate()
        {


            if (Input.GetKeyDown(KeyCode.W))
            {
                //pause_menu.SetActive(!pause_menu.activeSelf);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                //pause_menu.SetActive(!pause_menu.activeSelf);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                character_speed = Mathf.Lerp(character_speed, -1f, Time.fixedDeltaTime * 3);
                SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
                TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                character_speed = Mathf.Lerp(character_speed, 1f, Time.fixedDeltaTime * 3);
                SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
                TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
            }
            else
            {
                character_speed = Mathf.Lerp(character_speed, 0, 5 * Time.fixedDeltaTime);
                SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
            }

        }
    }

}