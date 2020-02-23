using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Activity2Part3.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        [Required]
        [Display(Name = "Username")]
        [StringLength(20, MinimumLength = 4)]
        public string Username { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 4)]
        public string Password { get; set; }

        public UserModel(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}