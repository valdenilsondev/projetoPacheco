using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacao : MonoBehaviour
{

    readonly float G = 100f;

    GameObject[] celestial;
    // Start is called before the first frame update
    void Start()
    {
        celestial = GameObject.FindGameObjectsWithTag("Celestial");
        InicialVelocity();
    }

    private void FixedUpdate()
    {
        Gravity();
    }

    public void Gravity()
    {
        foreach(GameObject a in celestial)
        {
            foreach(GameObject b in celestial)
            {
                if (!a.Equals(b))
                {
                    float m1 = a.GetComponent<Rigidbody>().mass;
                    float m2 = b.GetComponent<Rigidbody>().mass;

                    float r = Vector3.Distance(a.transform.position, b.transform.position);

                    a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized * (G * (m1 * m2) / (r * r)));

                }
            }
        }

    }
  
    public void InicialVelocity()
    {
        foreach (GameObject a in celestial)
        {
            foreach (GameObject b in celestial)
            {
                if (!a.Equals(b))
                {
                    float m2 = b.GetComponent<Rigidbody>().mass;

                    float r = Vector3.Distance(a.transform.position, b.transform.position);

                    a.transform.LookAt(b.transform);

                    a.GetComponent<Rigidbody>().velocity += a.transform.right * Mathf.Sqrt((G*m2)/r);

                }
            }
        }
    }
}
