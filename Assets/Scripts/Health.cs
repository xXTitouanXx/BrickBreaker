using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int pos_heart;
    void Update()
    {
        updateHeart();
    }

    void updateHeart(){
        if(pos_heart == 1 && FindObjectOfType<GameManager>().vies < 1){
            gameObject.SetActive(false);
        }
        if(pos_heart == 2 && FindObjectOfType<GameManager>().vies < 2){
            gameObject.SetActive(false);
        }
        if(pos_heart == 3 && FindObjectOfType<GameManager>().vies < 3){
            gameObject.SetActive(false);
        }
    }
}
