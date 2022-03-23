using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
            
        }
        
        
    }
}
//public int coins;
//public Text TextCoins;
//private void OnTriggerEnter(Collider col)
//{
    //if (col.gameObject.tag == "Money")
    //{
       // coins++;
        //col.gameObject.SetActive(false);
        //TextCoins.text = coins.ToString();
    //}
    //if (TextCoins.text == "10")
    //{


        //SceneManager.LoadScene(2);

    //}
//}
//}