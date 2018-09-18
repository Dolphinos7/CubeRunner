using UnityEngine;
using UnityEngine.UI;
public class ScoreKeeper : MonoBehaviour {
    public Rigidbody playerPhysx;
    public Transform player;
    public Text distance;
    bool SingleFinalScore = false;
	void FixedUpdate() {
        if(FindObjectOfType<GameManager>().gameHasEnded == false&&FindObjectOfType<Collision>().win==false)
            distance.text = player.position.z.ToString("0");
        if (FindObjectOfType<GameManager>().gameHasEnded == true && FindObjectOfType<Collision>().win == true)
        {
            if (SingleFinalScore == false)
            {
                distance.color = Color.yellow;
                distance.text = "You WIN!!!!!!!!" + "\n" + "Your final score is" + "\n" + player.position.z.ToString("0") + "\n" + "Press R to Restart";
                SingleFinalScore = true;
                playerPhysx.constraints = RigidbodyConstraints.FreezePosition;
                playerPhysx.useGravity = false;
                playerPhysx.constraints = RigidbodyConstraints.None;
                playerPhysx.AddForce(0, 5, 0, ForceMode.VelocityChange);
            }
        }
        else if (FindObjectOfType<GameManager>().gameHasEnded == true){
            if (SingleFinalScore == false)
            {
                distance.text = "Your final score is" + "\n" + player.position.z.ToString("0") + "\n" + "Press R to Restart";
                SingleFinalScore = true;
            }
           
        }
	}
}
