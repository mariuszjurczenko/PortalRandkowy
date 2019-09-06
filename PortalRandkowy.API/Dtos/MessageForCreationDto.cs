using System;

namespace PortalRandkowy.API.Dtos
{
    public class MessageForCreationDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime DateSent { get; set; }
        public string Content { get; set; }

        public MessageForCreationDto()
        {
            DateSent = DateTime.Now;
        }
    }
}