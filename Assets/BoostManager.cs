using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostManager : MonoBehaviour
{
    private GameManager gameManager;

    private void StartBoost()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void UpdateBoosts(Brick brick)
    {
        int randomNumber = Random.Range(1, 100);

        if (randomNumber < 25)
        {
            ActivateBoost(BoostType.SpeedUp);
        }
        else if (randomNumber < 50)
        {
            ActivateBoost(BoostType.ExtraLife);
        }
        else if (randomNumber < 75)
        {
            ActivateBoost(BoostType.BiggerPaddle);
        }
        else if (randomNumber < 100)
        {
            ActivateBoost(BoostType.NewBall);
        }
    }

    private void ActivateBoost(BoostType boostType)
    {
        switch (boostType)
        {
            case BoostType.SpeedUp:
                SpeedUp();
                break;
            case BoostType.ExtraLife:
                ExtraLife();
                break;
            case BoostType.BiggerPaddle:
                BiggerPaddle();
                break;
            case BoostType.NewBall:
                NewBall();
                break;
        }
    }

    private void SpeedUp()
    {
        // Code to speed up the ball
    }

    private void ExtraLife()
    {
        // Code to give an extra life
    }

    private void BiggerPaddle()
    {
        // Code to make the paddle bigger
    }

    private void NewBall()
    {
        // Code to add a new ball
    }
}

public enum BoostType
{
    SpeedUp,
    ExtraLife,
    BiggerPaddle,
    NewBall
}

