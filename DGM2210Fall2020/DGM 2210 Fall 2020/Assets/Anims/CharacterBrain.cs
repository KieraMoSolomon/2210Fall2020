using UnityEngine;
[CreateAssetMenu]
public class CharacterBrain : ScriptableObject
{
    private Vector3 position = Vector3.zero;
    
    public Vector3 Move(float speed)
    {
        //var  direction = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //position.Set(direction, 0,0 );
        
        return position;
    }

    public void Change()
    {
        Debug.Log("working");
    }
}
