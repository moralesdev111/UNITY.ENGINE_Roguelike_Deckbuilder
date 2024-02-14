using UnityEngine.UI;
using UnityEngine;

public class HighlightCardIfPlayable : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] Image image;

    void Update()
    {
        HighlightIfAllowed();
    }

    private void HighlightIfAllowed()
    {
        if (SceneManager.Instance.currentGameState == SceneManager.GameState.playerTurn)
        {
            if (SceneManager.Instance.player.currentEnergy >= GetComponent<CardInstance>().card.energyCost)
            {
                image.color = material.color;
            }
            else
            {
                image.color = Color.white;
            }
        }
        else
        {
            image.color = Color.white;
        }
    }
}
