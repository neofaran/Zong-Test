using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player, UI, ballspawnpoint, sphereprefeb,ballprefeb;
    public GameObject sphere, ball;
    Vector3 ballposition;
    public AudioSource ClickSound;

    // Start is called before the first frame update
    void Start()
    {
        sphere= Instantiate(sphereprefeb, ballspawnpoint.transform.position, ballspawnpoint.transform.rotation);
        sphere.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnNewBall()
    {
        if (sphere)
        {
            sphere.SetActive(false);
            ball = Instantiate(ballprefeb, sphere.transform.position, sphere.transform.rotation);
            Destroy(sphere);
            ClickSoundPlay();
        }
    }

    IEnumerator MoveToSpawnPoint()
    {
        yield return new WaitForSeconds(2);
        Player.GetComponent<CharacterController>().enabled = false;
        Player.transform.position = transform.position;
        Player.GetComponent<CharacterController>().enabled = true;
        UI.SetActive(false);
        sphere= Instantiate(sphereprefeb, ballspawnpoint.transform.position, ballspawnpoint.transform.rotation);
        sphere.SetActive(true);
        sphere.GetComponent<spherescript>().UI.SetActive(true);
        // Destroy(ball);
    }
   
    public void ClickSoundPlay()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
