using System.Collections.Generic;

namespace Fight.Scripts.Manager
{
    public class InputManager : ManagerBase<InputManager>
    {
        public HashSet<string> BlockingTags = new HashSet<string>();
    }
}