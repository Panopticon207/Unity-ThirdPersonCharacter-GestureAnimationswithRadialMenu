using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureAnimCancel : MonoBehaviour
{
    public Animator _animator;


    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void CancelWaveAnim()
    {
        _animator.SetBool("Wave", false);

    }
    public void CancelHipHopAnim()
    {
        _animator.SetBool("HipHop", false);

    }
    public void CancelLookAnim()
    {
        _animator.SetBool("Look", false);

    }
    public void CancelPrayingAnim()
    {
        _animator.SetBool("Praying", false);

    }
    public void CancelNoAnim()
    {
        _animator.SetBool("No", false);

    }
    public void CancelCheerAnim()
    {
        _animator.SetBool("Cheer", false);

    }
    public void CancelHandRaisingAnim()
    {
        _animator.SetBool("HandRaising", false);

    }
}
