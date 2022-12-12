using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxCollision : MonoBehaviour
{
    private GameManager GManager;
    // Start is called before the first frame update
    void Start()
    {
        GManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere")
        {
            if (this.name == "Box_C")
            {
                GManager.UI.SetActive(true);
                GManager.UI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You Droped In " + this.name;
                GManager.StartCoroutine("MoveToSpawnPoint");
            }
            else
            {
                GManager.UI.SetActive(true);
                GManager.UI.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You Droped In " + this.name;
                transform.GetChild(1).gameObject.SetActive(true);
                transform.GetChild(2).gameObject.SetActive(false);
                Destroy(GManager.ball);
            }
        }
    }
}
