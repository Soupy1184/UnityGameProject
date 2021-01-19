using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscilatingPosition : MonoBehaviour
 {
     public enum OccilationFuntion { Sine, Cosine }
     Rigidbody2D rb;
     public float speed;
 
     public void Start ()
     {
     	rb = GetComponent<Rigidbody2D>(); 
         //to start at zero
         StartCoroutine (Oscillate (OccilationFuntion.Sine, 1f));
         //to start at scalar value
         //StartCoroutine (Oscillate (OccilationFuntion.Cosine, 1f));
     }
 
     private IEnumerator Oscillate (OccilationFuntion method, float scalar)
     {
         while (true)
         {
             if (method == OccilationFuntion.Sine)
             {
                 transform.position = new Vector3((Mathf.Sin (Time.time) * scalar)+0.72f, -0.42f, 0);
             }
             else if (method == OccilationFuntion.Cosine)
             {
                 transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, 0, 0);
             }
             yield return new WaitForEndOfFrame ();
         }
     }
 }
