using UnityEngine;
public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        if (!triggeredBody.CompareTag("Ball")) return; 
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();
        if (ballRigidBody != null)
        {
            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;
            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;
            ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
        }
    }
 }  