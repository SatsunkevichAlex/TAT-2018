using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_8
{
    /// <summary>
    /// Class command for input information about user 
    /// </summary>
    class InformationInput : ICommand
    {
        User user;
        public InformationInput(User u)
        {
            user = u;
        }
        /// <summary>
        /// Execute first name input command
        /// </summary>
        public void Execute()
        {
            user.InformationInput();
        }
    }
}
