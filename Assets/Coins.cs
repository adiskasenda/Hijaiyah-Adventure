using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }

    static int coin = 0;
     AudioClip coinSound;
     void Start()
     {
         coin = 0;
     }
 void OnTriggerEnter2D(Collider2D other)
     {
         if (other.tag == "karakter")
         {
             coin++;    
             AudioSource.PlayClipAtPoint(this.GetComponent<AudioSource>().clip, this.transform.position);
             Destroy(this.gameObject);
  
         }
     }
     void OnDisable(){
         PlayerPrefs.SetInt ("coin", coin);
     }
     IEnumerator Ding(){
             yield return new WaitForSeconds (0.4F);
        }
}
