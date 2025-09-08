using UnityEngine;

public class Coindestroy : MonoBehaviour
{

    


    private void OnTriggerEnter(Collider other)

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
