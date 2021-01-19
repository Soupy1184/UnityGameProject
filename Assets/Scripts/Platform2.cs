using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    // Start is called before the first frame update
    public enum OccilationFuntion { Sine, Cosine }
     Rigidbody2D rb;
     public float speed;
 
     public void Start ()
     {
     	rb = GetComponent<Rigidbody2D>(); 
         //to start at zero
         StartCoroutine (Oscillate (OccilationFuntion.Sine, 2f));
         //to start at scalar value
         //StartCoroutine (Oscillate (OccilationFuntion.Cosine, 1f));
     }
 
     private IEnumerator Oscillate (OccilationFuntion method, float scalar)
     {
         while (true)
         {
             if (method == OccilationFuntion.Sine)
             {
                 transform.position = new Vector3((Mathf.Sin (Time.time) * scalar)+7.14f, 0.59f, 0);
             }
             else if (method == OccilationFuntion.Cosine)
             {
                 transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, 0, 0);
             }
             yield return new WaitForEndOfFrame ();
         }
     }
}
