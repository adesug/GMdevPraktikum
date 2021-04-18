using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float Kecepatan = 50f;
    private Rigidbody rb;
    private int point;
    public Text pointText;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        point = 0;
        SetCounText();
        // Debug.Log(point);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * Kecepatan);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * Kecepatan);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * Kecepatan);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * Kecepatan);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * -Kecepatan);
        }

        // transform.Translate(Kecepatan * Input.GetAxis("Horizontal") * Time.deltaTime, 0.0f, Kecepatan * Input.GetAxis("Vertical") * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Musuh"))
        {
            other.gameObject.SetActive(false);
            point = point + 1;
            SetCounText();
        }
    }

    void SetCounText()
    {
        pointText.text = "Point : "+ point.ToString();
        // Debug.Log(point);
    }
}
