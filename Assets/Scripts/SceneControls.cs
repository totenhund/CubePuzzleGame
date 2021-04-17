using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControls : MonoBehaviour
{
    public bool isFinish = false;

    private void FixedUpdate()
    {
        if(!isFinish)
		{
			if(Input.GetKey(KeyCode.R))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		
			if(Input.GetKey(KeyCode.Q))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
		}else{
            if(Input.GetKey(KeyCode.R))
			{
				SceneManager.LoadScene(0);
			}
        }

        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }

}
