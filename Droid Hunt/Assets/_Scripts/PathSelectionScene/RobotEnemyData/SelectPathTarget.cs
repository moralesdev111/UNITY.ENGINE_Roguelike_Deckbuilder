using UnityEngine;

public class SelectPathTarget : MonoBehaviour
{
    public EnemyRobot enemyRobot;
    [SerializeField] Player2D player2D;

    private void OnMouseDown()
    {
        if (CheckIfVisited())
        {
            // Location already visited
            Debug.Log("This location has already been visited by the player.");
        }
        else
        {
            // Location not visited, allow selection
            player2D.chosenPath = this.gameObject;
            player2D.SavePlayer();
        }
    }

    public bool CheckIfVisited()
    {
        // Check the tag of the location
        string locationTag = gameObject.tag;

        // Check the corresponding boolean variable in Player2D
        switch (locationTag)
        {
            case "BattleLocation":
                return player2D.firstVisited;
            case "BattleLocation2":
                return player2D.secondVisited;
            case "BattleLocation3":
                return player2D.thirdVisited;
            case "BattleLocation4":
                return player2D.fourthVisited;
            case "BattleLocation5":
                return player2D.fifthVisited;
            default:
                return false; // Default to false if tag not recognized
        }
    }
}
