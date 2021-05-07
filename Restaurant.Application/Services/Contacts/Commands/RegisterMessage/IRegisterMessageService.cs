using Restaurant.Common.Dto;
using Restaurant.Application.Interfaces.Contexts;
using Restaurant.Domain.Entities;
using System;
namespace Restaurant.Application.Services.Contacts.Commands.RegisterMessage
{
    public interface IRegisterMessageService
    {
        ResultDto<RequestRegisterMsgDto> Execute(RequestRegisterMsgDto request);
    }
    public class RegisterMessageService : IRegisterMessageService
    {
        private readonly Interfaces.Contexts.IDataBaseContext _context;

        public RegisterMessageService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<RequestRegisterMsgDto> Execute(RequestRegisterMsgDto request)
        {
            try
            {
                //if (string.IsNullOrWhiteSpace(request.Email))
                //{
                //    return new ResultDto<RequestRegisterMsgDto>()
                //    {
                //        Data = new RequestRegisterMsgDto()
                //        {
                //            UserId = 0,
                //        },
                //        IsSuccess = false,
                //        Message = "پست الکترونیک را وارد نمایید"
                //    };
                //}

                //if (string.IsNullOrWhiteSpace(request.FullName))
                //{
                //    return new ResultDto<RequestRegisterMsgDto>()
                //    {
                //        Data = new RequestRegisterMsgDto()
                //        {
                //            UserId = 0,
                //        },
                //        IsSuccess = false,
                //        Message = "نام را وارد نمایید"
                //    };
                //}
                //if (string.IsNullOrWhiteSpace(request.Password))
                //{
                //    return new ResultDto<RequestRegisterMsgDto>()
                //    {
                //        Data = new RequestRegisterMsgDto()
                //        {
                //            UserId = 0,
                //        },
                //        IsSuccess = false,
                //        Message = "رمز عبور را وارد نمایید"
                //    };
                //}
                //if (request.Password != request.RePasword)
                //{
                //    return new ResultDto<RequestRegisterMsgDto>()
                //    {
                //        Data = new RequestRegisterMsgDto()
                //        {
                //            UserId = 0,
                //        },
                //        IsSuccess = false,
                //        Message = "رمز عبور و تکرار آن برابر نیست"
                //    };
                //}
                //string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";

                //var match = Regex.Match(request.Email, emailRegex, RegexOptions.IgnoreCase);
                //if (!match.Success)
                //{
                //    return new ResultDto<RequestRegisterMsgDto>()
                //    {
                //        Data = new RequestRegisterMsgDto()
                //        {
                //            UserId = 0,
                //        },
                //        IsSuccess = false,
                //        Message = "ایمیل خودرا به درستی وارد نمایید"
                //    };
                //}


                //var passwordHasher = new PasswordHasher();
                //var hashedPassword = passwordHasher.HashPassword(request.Password);

                ContactTable Contact = new ContactTable()
                {
                    Email = request.Email,
                    FullName = request.FullName,
                    Subject = request.Subject,
                    Message = request.Message


                };

                //List<UserInRole> userInRoles = new List<UserInRole>();

                //foreach (var item in request.roles)
                //{
                //    var roles = _context.Roles.Find(item.Id);
                //    userInRoles.Add(new UserInRole
                //    {
                //        Role = roles,
                //        RoleId = roles.Id,
                //        User = user,
                //        UserId = user.Id,
                //    });
                //}
                //user.UserInRoles = userInRoles;

                _context.ContactTables.Add(Contact);

                _context.SaveChanges();

                return new ResultDto<RequestRegisterMsgDto>()
                {
                    Data = new RequestRegisterMsgDto()
                    {
                        Id = Contact.Id,
                    },
                    IsSuccess = true,
                    Message = "Thank you for your message. It has been sent.",
                };
            }
            catch (Exception ex)
            {
                return new ResultDto<RequestRegisterMsgDto>()
                {
                    Data = new RequestRegisterMsgDto()
                    {
                        Id = 0,
                    },
                    IsSuccess = false,
                    Message = "There was an error trying to send your message. Please try again later." + ex.ToString()
                };
            }
        }
    }




}
