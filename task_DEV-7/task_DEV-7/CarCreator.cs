﻿using System;

namespace task_DEV_7
{
    /// <summary>
    /// Define abstract factory method Create(), which returns object Car
    /// </summary>
    public abstract class CarCreator
    {
        public string Name { get; set; }
        public CarCreator(string n)
        {
            Name = n;
        }
        /// <summary>
        /// Abstract facrory method
        /// </summary>
        /// <returns>Object Car</returns>
        public abstract Car Create();
    }
}
