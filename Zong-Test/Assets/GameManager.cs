using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player, UI, ballspawnpoint, ballprefeb;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MoveToSpawnPoint()
    {
        yield return new WaitForSeconds(2);
        Player.transform.GetComponentInChildren<CharacterController>().enabled = false;
        Player.transform.position = transform.position;
        Player.transform.GetComponentInChildren<CharacterController>().enabled = true;
        Destroy(ball);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && ball==null)
        {
            ball = Instantiate(ballprefeb, ballspawnpoint.transform.position, ballspawnpoint.transform.rotation);
        }
    }
}
