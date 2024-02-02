using _Pattern.Pool.Scripts;
using UnityEngine;

namespace _Game.Scripts.Character
{
    public class CharacterController : GameUnit
    {
        [SerializeField] private Animator animator;
        
        private string _currentAnimName;
        
        public virtual void OnInit()
        {
            
        }

        public virtual void OnDespawn()
        {
            
        }

        public void ChangeAnim(string animName)
        {
            if (_currentAnimName == animName)
            {
                return;
            }    
            
            animator.ResetTrigger(_currentAnimName);
            _currentAnimName = animName;
            animator.SetTrigger(_currentAnimName);
        }
    }
}
