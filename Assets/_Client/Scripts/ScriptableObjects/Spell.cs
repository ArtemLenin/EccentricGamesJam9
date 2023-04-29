using UnityEngine;

[CreateAssetMenu()]
public class Spell : ScriptableObject
{
    public string Name;
    public string Shape;
    public int Level;
    public AudioClip Sound;
    public Sprite Image;
}