﻿using AutoMapper;
using Infrastructure.Messenger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Messenger.Controllers
{
    public class ContactController:GenericController<Contact,ContactDto,ContactReadDto>
    {

        public ContactController(MessengerDbContext ctx,AutoMapper.IConfigurationProvider cfg):base(ctx, cfg)
        {
        }

    }
}
