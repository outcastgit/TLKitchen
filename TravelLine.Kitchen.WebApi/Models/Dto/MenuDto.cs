using System.Runtime.Serialization;

namespace TravelLine.Kitchen.WebApi.Models.Dto
{
    [DataContract]
    public class MenuDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "menu")]
        public string Dish { get; set; }
    }
}