using System.Runtime.Serialization;

namespace TravelLine.Kitchen.WebApi.Models.Dto
{
    [DataContract]
    public class UserDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}