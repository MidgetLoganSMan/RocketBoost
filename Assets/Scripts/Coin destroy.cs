using UnityEngine;

public class Coindestroy : MonoBehaviour
{

    


    private void OnCollisionEnter(Collision other)

    {




        if (other.gameObject.tag == "Player")

        {
            Debug.Log("Coin collected");
            //Destoy game object
            Destroy(gameObject);
            //else do nothing
            

        }





    }

}
