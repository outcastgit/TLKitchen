using System.Runtime.Serialization;
using System;

namespace TravelLine.Kitchen.WebApi.Models.Dto
{
    [DataContract]
    public class OrderDto
    {

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "userId")]
        public int UserId { get; set; }

        [DataMember(Name = "dishid")]
        public int DishId { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }
    }
}