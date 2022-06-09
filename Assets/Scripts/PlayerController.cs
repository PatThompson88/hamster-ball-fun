using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 0f;
    // public TextMeshProUGUI scoreText;
	// public GameObject winTextObject;
    public int score;
    private Rigidbody rb;
    private float movementX;
    private float movementZ;
    void Start()
    {
        score = 0;
        // SetScoreText();
        rb = GetComponent<Rigidbody>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 movementVector = context.ReadValue<Vector2>();
        movementX = movementVector.x;
        movementZ = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0, movementZ);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        // access tag element and check that it is a "Pickup"
        if(other.gameObject.CompareTag("Pickup")){
            other.gameObject.SetActive(false);
            score += 50;
            SetScoreText();
        }
    }

    void SetScoreText()
	{
		// scoreText.text = "SCORE: " + score.ToString();

		if (score >= 250){
            // Set the text value of your 'winText'
            // winTextObject.SetActive(true);
		}
	}
}
