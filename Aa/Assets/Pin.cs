using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;
    
	void Start () {
		
	}
	
	void Update () {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            //int rnd = Random.Range(0,3);
            //switch (rnd)
            //{
            //    case 0:
            //    col.GetComponent<RotateEarth>().speed *= -1f;
            //            break;
            //}
            Score.pinCount++;
            isPinned = true;
        }
        else if(col.tag == "Pin")
        {
            //End game
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
