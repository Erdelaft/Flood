﻿using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public VirtualController joystick;
    public AmbilSampah ambilSampah;
    public float playerSpeed = 4f;
    public Animation playerAnim;
    Transform playerPos;
    int skor = 0;
    
	// Update is called once per frame
	void Update ()
    {
        playerPos = GetComponent<Transform>();
        ambilSampah = GetComponent<AmbilSampah>();

        transform.position = playerPos.position;

        if(joystick.InputDirection != Vector3.zero)
        {
            transform.position += joystick.InputDirection * playerSpeed;
            
        }
        
	}

    void OnCollisionEnter(Collision ambil)
    {
        if (ambil.gameObject.tag == "Sampah")
        {
            Destroy(ambil.gameObject);

            skor++;

            ambilSampah.tempSkor[0] = skor.ToString();
            Debug.Log( "Skor : " + ambilSampah.tempSkor[0]);
        }
    }
}
