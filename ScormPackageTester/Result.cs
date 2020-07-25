using System.Collections;
using System.Collections.Generic;

namespace ScormPackageTester
{
    /// <summary>
    /// Represents a result of a check.
    /// </summary>
    public class Result
    {
        private List<string> _validationMessages = new List<string>();
        
        /// <summary>
        /// Did the check pass or fail.
        /// </summary>
        public bool Passed { get; set; }

        /// <summary>
        /// Return validation messages.
        /// </summary>
        /// <returns>Validation messages array.</returns>
        public string[] GetMessages()
        {
            return _validationMessages.ToArray();
        }

        public void AddMessage(string message)
        {
            _validationMessages.Add(message);
        }
    }
}