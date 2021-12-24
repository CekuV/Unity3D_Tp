using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    public GameObject patlama;
    public GameObject mainObject,childObject;
    public GameObject[] childObjectList;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Carpisma Gerceklesti");  // Carpisma bilgisi almak icin
        // Destroy(collision.gameObject); // Carpilan objeyi yoketmek icin
        
        if (collision.gameObject.tag == "Portal")
        {
            Debug.Log ( collision.transform.name ); // Carpilan nesnenin ismi

            mainObject = collision.gameObject; // Debug.Log(mainObject.name);

            if (mainObject != null)
            {
                childObjectList = GameObject.FindGameObjectsWithTag("Portal"); // Portal tagi altindaki objeleri diziye atma 
                
                do
                {
                    
                    childObject = childObjectList[Random.Range(0, childObjectList.Length)];

                    // Debug.Log(" Yeni Portal - " + childObject.name);    // Isinlanilacak portal
                    // Debug.Log(" Eski Portal - " + mainObject.name);     // Eski Portal


                } while ( childObject == collision.gameObject ); // Ayni portala isinlama yapmamak icin

                Debug.Log(" Isinlandin : " + childObject.name);

                this.gameObject.transform.position = new Vector3(
                    childObject.transform.position.x , 
                    0.16f,
                    childObject.transform.position.z + 0.3f);
                
            }

        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            
            Destroy(this.gameObject);      // carpan objenin yok olmasi icin

            Instantiate(patlama, this.gameObject.transform.position, this.gameObject.transform.rotation);   // patlama efekti cagirma

            // Invoke("ExitEditor", 1.1f);

            UnityEditor.EditorApplication.isPlaying = false;

        }
    }
    /*private void ExitEditor() { UnityEditor.EditorApplication.isPlaying = false; } */
}
