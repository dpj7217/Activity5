using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

using UserModel = Activity2Part3.Models.UserModel;

namespace HelloWorldService
{
    [DataContract]
    public class DTO
    {
        [DataMember]
        public int ErrorCode { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public List<UserModel> Data {get; set;}

        public DTO(int errorCode, string errorMessage, List<UserModel> data)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.Data = data;
        }
    }
}