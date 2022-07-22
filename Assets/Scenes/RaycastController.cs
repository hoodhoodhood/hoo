using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public Material _Green;
    public Material _Blue;

    public GameObject _gameObject;
    
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame

    public IEnumerator Enumerator(RaycastHit hit)
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("3√ ");
        hit.collider.gameObject.GetComponent<MeshRenderer>().material = _Green;
        _gameObject = hit.collider.gameObject;
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            StartCoroutine(Enumerator(hit));
        }
        else
        {
            _gameObject.GetComponent<MeshRenderer>().material = _Blue;
        }
    }
}
