using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip jumpAudioClip;
    public AudioClip crashAudioClip;
    public ParticleSystem _footStepParticle;
    public ParticleSystem _particleForDeath;
    private AudioSource _playerAudioSource;
    private Rigidbody _playerRb;
    private Animator _playerAnimator;
    public float jumpForce;
    private bool _isGrounded;
    public bool IsGameOver;
    private void Start()
    {
        _playerAudioSource = GetComponent<AudioSource>();
        _playerRb = GetComponent<Rigidbody>();
        _playerAnimator = GetComponent<Animator>();
        Physics.gravity *= 2;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & _isGrounded & IsGameOver == false)
        {
            _playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            _isGrounded = false;
            _playerAnimator.SetTrigger("Jump_trig");
            _footStepParticle.Stop();
            _playerAudioSource.PlayOneShot(jumpAudioClip,1.0f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
            _footStepParticle.Play();
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            IsGameOver = true;
            _playerAnimator.SetBool("Death_b",true);
            _playerAnimator.SetInteger("DeathType_int",1);
            _particleForDeath.Play();
            _footStepParticle.Stop();
            _playerAudioSource.PlayOneShot(crashAudioClip,1.0f);
        }
    }
}
