//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Socialbodhi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participant
    {
        public long ParticipantsId { get; set; }
        public Nullable<long> InstanceId { get; set; }
        public string ParticipantsName { get; set; }
        public string Participantsemail { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<long> ChoiceId { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
    
        public virtual Choice Choice { get; set; }
        public virtual Instance Instance { get; set; }
    }
}
