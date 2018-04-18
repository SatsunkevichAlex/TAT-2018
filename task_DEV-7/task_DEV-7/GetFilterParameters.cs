using System;

namespace task_DEV_7
{
    /// <summary>
    /// Class command for create filter parameters
    /// </summary>
    class GetFilterParameters : ICommand 
    {
        FilterParameters filterParameters;
        public GetFilterParameters(FilterParameters r)
        {
            filterParameters = r;
        }
        /// <summary>
        /// Execute method which returns filter parameters
        /// </summary>
        public void Execute()
        {
            filterParameters.Parameters();
        }
    }
}
