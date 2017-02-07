using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //this or the other one is fine
using System.Linq;
using System.Web;


namespace CommentForm.Models
{
    public class CommentFormModel
    {   
        //Our ID keeps track of each instance
        [Key]
        public int ID { get; set; }   //need to set this up as a property; the other form of properites with the explicit get set and return value can be used but not necessary

        public string Name { get; set; }
        public string Comment { get; set; }
        public int Priority { get; set; }

        //remember to build
         
    }
}