using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score;
    Rigidbody rb;
    public float force;
    public Text textScore;
    GameObject Menang;
    GameObject Retry;
    GameObject Exit;
    GameObject Kalah;
    GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.Find ("Player");
        //cari panel Menang
        Menang = GameObject.Find ("Menang");
        Menang.SetActive (false);
        Retry =  GameObject.Find ("RetryBTN");
        Retry.SetActive (false);
        Exit = GameObject.Find ("ExitBTN");
        Exit.SetActive (false);
        Kalah = GameObject.Find ("Kalah");
        Kalah.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        //atur input Android
        float moveX = Input.acceleration.x;
        float moveY = Input.acceleration.y;

        // menghubungkan input dengan fungsi gerak
        Vector3 posisi = new Vector3(moveX,0f,moveY);
        // fungsi gerak
        rb.AddForce(posisi * force);
        
        //atur input PC
        // float moveX = Input.GetAxis("Horizontal");
        // float moveZ = Input.GetAxis("Vertical");

        // //menghubungkan input dengan fungsi gerak
        // Vector3 posisi = new Vector3(moveX,0f,moveZ);
        //fungsi gerak
        // rb.AddForce(posisi * force);
        if (Player.transform.position.y < -5)
                {
                    Retry.SetActive (true);
                    Exit.SetActive (true);
                    Kalah.SetActive (true);
                    Destroy (gameObject);
                }
        
    }
    //fungsi trigger
     void OnTriggerEnter(Collider other) {
            //jika other adalah kubus maka kubus hilang dan skor bertambah
            if (other.gameObject.tag == "Kubus")
            {
                //menghilangkan kubus
                Destroy(other.gameObject);
                //score bertambah dan tampilkan score
                score++;
                textScore.text = "Score: " + score;
                if (score == 9)
                {
                    Retry.SetActive (true);
                    Exit.SetActive (true);
                    Menang.SetActive (true);
                    Destroy (gameObject);
                    Debug.Log("ye");
                    
                } 
                
                
            }
            
        }
    
}
