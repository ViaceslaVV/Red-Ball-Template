using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporter : MonoBehaviour
{
    public float stayTime;
    public float teleportTime = 3f;
    public string nextScene;

    void Update()
    {
        
      
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;


        stayTime += Time.deltaTime;
        if(stayTime >= teleportTime)
        {
            GameManager.instance.Win();
            SceneManager.LoadScene(nextScene);
        }

        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        stayTime = 0;
    }
}
