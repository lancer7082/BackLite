using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackLite.Models
{

    public enum Gender
    {
        Male,
        Female
    }

    /*
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Code { get; set; }
    }

    public class DictionaryItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Parent")]
        public int? ParentId { get; set; }
        [StringLength(100)]
        public string Value { get; set; }
        [StringLength(50)]
        public string Code { get; set; }

        public virtual DictionaryItem Parent { get; set; }
    }
    */

    public class Client
    {
        //[Key]
        public int ClientId { get; set; }

        //[StringLength(100)]
        //[Display(Name = "First Name")]
        public string FirstName { get; set; }
        //[StringLength(100)]
        public string LastName { get; set; }
        //[StringLength(100)]
        public string Email { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        //[Column(TypeName = "smallint")]
        public Gender Gender { get; set; }

        //[ForeignKey("Country")]
        //public int CountryId { get; set; }
        //public virtual Country Country { get; set; }

        public string Code { get; set; }

        //documents     
        //public ICollection<Document> Documents { get; set; }
    }

    /*
    public class Document
    {
        //[Key]
        public int DocumentId { get; set; }
        //[ForeignKey("Client")]
        public int ClientId { get; set; }
        //[StringLength(50)]
        public string Number { get; set; }
        //[StringLength(50)]
        public string Serial { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime? DateEnd { get; set; }
        //[StringLength(500)]
        //[Display(Name = "Issued By")]
        public string IssuedBy { get; set; }
        //[ForeignKey("Country")]
        //[Display(Name = "Country Of Issue")]
        public int CountryId { get; set; }
        //document type
        //[ForeignKey("Type")]
        public int TypeId { get; set; }

        //public virtual Country Country { get; set; }
        public virtual Client Client { get; set; }
        //public virtual DictionaryItem Type { get; set; }
    }
    */
}