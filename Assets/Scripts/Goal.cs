using UnityEngine;


public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    //public EventTrigger.TriggerEvent score;
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored...");
                GameObject.Find("Game Manager").GetComponent<GameManager>().Player2Scored();
            }
            else
            {
                Debug.Log("Player 1 Scored...");
                GameObject.Find("Game Manager").GetComponent<GameManager>().Player1Scored();
            }
        }    
    }
}
