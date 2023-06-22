using Unity.VisualScripting;
using UnityEngine;

public class Border : MonoBehaviour
{   
    private void OnCollisionEnter2D(Collision2D collision)
    {     
        if (collision.collider.GetComponent<Jellyfish>())
        {
            GameObject gameObject = collision.collider.GameObject();            
            Destroy(gameObject);
        }        
    }    
}
