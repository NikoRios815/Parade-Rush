using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lvl0result : MonoBehaviour
{
    float timer = 50;
    public Text time_count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float ballons = Inventory_Manager.Item_Count;
        timer = timer - Time.deltaTime;
        time_count.text = timer.ToString();

        if (ballons == 10)
        {
            SceneManager.LoadScene("ResultA");
        }

        if (timer <= 0)
        {
            if (ballons < 5)
            {
                SceneManager.LoadScene("ResultF");
            }
            else if (ballons < 7)
            {
                SceneManager.LoadScene("ResultC");
            }
            else if (ballons < 10)
            {
                SceneManager.LoadScene("ResultB");
            }
            else
            {
                SceneManager.LoadScene("ResultA");
            }
        }
    }
}
