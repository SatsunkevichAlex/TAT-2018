using System;

namespace task_DEV_7
{
    /// <summary>
    /// Body type of a car
    /// </summary>
    class BodyType
    {
        private string type;
        public string Type { get; set; }

        public BodyType(string bodytype)
        {
            type = bodytype;
        }
    }
}
