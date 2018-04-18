using System;

namespace task_DEV_7
{
    /// <summary>
    /// Class command for ceating cars catalog
    /// </summary>
    public class CreateCarsCatalog : ICommand
    {
        CarsCatalog carsCatalog;
        public CreateCarsCatalog(CarsCatalog cat)
        {
            carsCatalog = cat;
        }
        /// <summary>
        /// Execute method which returns cars catalog
        /// </summary>
        public void Execute()
        {
            carsCatalog.Catalog();
        }
    }
}
