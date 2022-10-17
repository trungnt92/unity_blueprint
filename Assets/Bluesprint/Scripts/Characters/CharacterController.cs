using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
	private CharacterData characterData;
    public float speed = 5;
    public Character character;

    private void Awake()
    {
        character = characterData.CreateCharacter();
    }

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        transform.position = new Vector3(transform.position.x + horizontal * Time.deltaTime * speed, transform.position.y, transform.position.z + vertical * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        var effectCmp = other.gameObject.GetComponent<EffectComponent>();
        if (effectCmp != null)
        {
            effectCmp.effect.Apply(character);
            Destroy(other.gameObject);
        }
    }
}

