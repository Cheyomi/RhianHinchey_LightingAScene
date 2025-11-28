using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;


public class TriggerScript : MonoBehaviour
{

    public bool isPlayed;

    [SerializeField] private PlayableDirector playableDirector;

    public void OnTriggerEnter(Collider other)
    {
        playableDirector.Play();

        GetComponent<MeshRenderer>().enabled = false;

    }


}
