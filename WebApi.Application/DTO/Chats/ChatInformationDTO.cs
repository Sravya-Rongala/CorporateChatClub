﻿namespace WebApi.Application.DTO.Chats
{
    public class ChatInformationDTO
    {
        public Guid ChatId { get; set; }

        public string? ChatName { get; set; }

        public bool IsFavouriteChat { get; set; }

        public bool IsChatMuted { get; set; }


    }
}
