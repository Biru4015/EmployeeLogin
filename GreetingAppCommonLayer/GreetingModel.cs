namespace GreetingAppCommonLayer
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This class contains the code for employee details parameters.
    /// </summary>
    public class GreetingModel
    {
        /// <summary>
        /// Employee id
        /// </summary>
        private int id;

        /// <summary>
        /// The full name
        /// </summary>
        private string fullName;

        /// <summary>
        /// The age
        /// </summary>
        private int age;

        /// <summary>
        /// The email identifier
        /// </summary>
        private string emailId;

        /// <summary>
        /// The work experience
        /// </summary>
        private int workExp;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        /// 
        [Key]
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName
        {
            get
            {
                return this.fullName;
            }

            set
            {
                this.fullName = value;
            }
        }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        public string EmailId
        {
            get
            {
                return this.EmailId;
            }

            set
            {
                this.EmailId = value;
            }
        }

        /// <summary>
        /// Gets or sets the work experience.
        /// </summary>
        /// <value>
        /// The work experience.
        /// </value>
        public int WorkExp
        {
            get
            {
                return this.workExp;
            }

            set
            {
                this.workExp = value;
            }
        }
    }
}
