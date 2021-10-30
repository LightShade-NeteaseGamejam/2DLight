using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InGame
{
    public class InGameControl : MonoBehaviour
    {
        public bool allowChangeView;
        public GameObject TopViewPlayer;
        private CollisionDetect topDetect;
        public GameObject SideViewPlayer;
        private CollisionDetect sideDetect;
        public GameObject pause_menu;
        public GameObject Theater;
        public CameraControl camera;
        public LevelLoader levelLoader;

        private float character_speed;

        // Start is called before the first frame update
        void Start()
        {
            character_speed = 0;
            topDetect = TopViewPlayer.GetComponent<CollisionDetect>();
            sideDetect = SideViewPlayer.GetComponent<CollisionDetect>();
        }

        private void Update()
        {

            // Record progress
            DataStorage.progress = SceneManager.GetActiveScene().name;
            // toggle pause menu
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause_menu.SetActive(!pause_menu.activeSelf);
            }

            if (Input.GetKeyDown(KeyCode.W) && allowChangeView)
            {
                camera.is_side_view = !camera.is_side_view;
                DataStorage.is_side_view = !DataStorage.is_side_view;
                Theater.SetActive(!Theater.activeSelf);
            }
            TopViewPlayer.GetComponent<Animator>().SetFloat("speed", character_speed);
            SideViewPlayer.GetComponent<Animator>().SetFloat("speed", character_speed);
        }
        IEnumerator Dead()
        {
            // reset health
            DataStorage.emotion_state = 0.1f;
            //Wait
            yield return new WaitForSeconds(2f);
            // Restart
            levelLoader.LoadPrevLevel();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (DataStorage.emotion_state <= 0)
            {
                camera.is_side_view = true;
                DataStorage.is_side_view = !DataStorage.is_side_view;
                SideViewPlayer.GetComponent<Animator>().SetBool("is_dead", true);
                StartCoroutine(Dead());
            }
            if (Input.GetKey(KeyCode.A))
            {
                if (camera.is_side_view)
                {
                    if (sideDetect.distance_left > 1f)
                    {
                        SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
                        character_speed = Mathf.Lerp(character_speed, -1f, Time.fixedDeltaTime * 3);
                    }
                    else
                    {
                        character_speed = Mathf.Lerp(character_speed, 0, 5 * Time.fixedDeltaTime);
                        SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                        TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                    }
                }
                else
                {
                    if (topDetect.distance_left > 1f)
                    {
                        TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
                        character_speed = Mathf.Lerp(character_speed, -1f, Time.fixedDeltaTime * 3);
                    }
                    else
                    {
                        character_speed = Mathf.Lerp(character_speed, 0, 5 * Time.fixedDeltaTime);
                        SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                        TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                    }
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (camera.is_side_view)
                {
                    if (sideDetect.distance_right > 1f)
                    {
                        SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
                        character_speed = Mathf.Lerp(character_speed, 1f, Time.fixedDeltaTime * 3);
                    }
                    else
                    {
                        character_speed = Mathf.Lerp(character_speed, 0, 5 * Time.fixedDeltaTime);
                        SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                        TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                    }
                }
                else
                {
                    if (topDetect.distance_right > 1f)
                    {
                        TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", true);
                        character_speed = Mathf.Lerp(character_speed, 1f, Time.fixedDeltaTime * 3);
                    }
                    else
                    {
                        character_speed = Mathf.Lerp(character_speed, 0, 5 * Time.fixedDeltaTime);
                        SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                        TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                    }
                }
            }
            else
            {
                character_speed = Mathf.Lerp(character_speed, 0, 5 * Time.fixedDeltaTime);
                SideViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
                TopViewPlayer.GetComponent<Animator>().SetBool("is_walking", false);
            }

            TopViewPlayer.transform.position += new Vector3(character_speed * 2.5f, 0, 0) * Time.deltaTime;
            SideViewPlayer.transform.position += new Vector3(character_speed * 2.5f, 0, 0) * Time.deltaTime;


        }
    }

}