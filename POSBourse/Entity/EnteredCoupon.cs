//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSBourse.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnteredCoupon
    {
        public int Id { get; set; }
        public decimal value { get; set; }
        public string store { get; set; }
        public System.DateTime datetime { get; set; }
        public string transactionSpecificity { get; set; }
        public int TransactionId { get; set; }
        public bool exchange { get; set; }
        public string onlyOn { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
