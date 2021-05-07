
using Restaurant.Application.Services.Contacts.Commands.RegisterMessage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        RegisterMessageService RegisterMessageService { get; }
    }
}
