﻿namespace GreetingAppCommonLayer
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// This class contains the code for employee details parameters.
    /// </summary>
    public class GreetingModel
    {
        /// <summary>
        /// The employee identifier
        /// </summary>
        private int employeeID;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The email identifier
        /// </summary>
        private string emailID;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        /// <summary>
        /// The mobile
        /// </summary>
        private string mobile;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
      
        [Key]
        public int EmpID
        {
            get
            {
                return this.employeeID;
            }

            set
            {
                this.employeeID = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [MinLength(3)]
        [Required(ErrorMessage ="Please eneter proper name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$", ErrorMessage = "Email is not valid.")]
        public string Email
        {
            get
            {
                return this.emailID;
            }

            set
            {
                this.emailID = value;
            }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required(ErrorMessage = "Please enter valid password")]
        [RegularExpression(@"^[0-9a-zA-Z]{8,}$", ErrorMessage = "Password is not valid.")]
        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
        [Required]
        [MinLength(10),MaxLength(12)]
        public string Mobile
        {
            get
            {
                return this.mobile;
            }

            set
            {
                this.mobile = value;
            }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [Required]
        [MinLength(3)]
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }
    }
}
