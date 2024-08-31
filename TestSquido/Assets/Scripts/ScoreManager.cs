using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] 
    private TextMeshProUGUI scoreText;
    
    private int _score;

    private void Start()
    {
        SetScoreText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Ball"))
        {
            Rigidbody colliderRigidbody = other.gameObject.GetComponent<Rigidbody>();
            float colliderGameObjectDirection = Vector3.Dot(colliderRigidbody.velocity.normalized, Vector3.down);
            //Give a minimum of angle to make sure it's coming from the top of the hoop
            if (colliderGameObjectDirection > 0.5)
            {
                this._score++;
                SetScoreText();
            }
        }
    }

    public void ResetScore()
    {
        this._score = 0;
        SetScoreText();
    }

    private void SetScoreText()
    {
        this.scoreText.SetText(_score.ToString());
    }
}
