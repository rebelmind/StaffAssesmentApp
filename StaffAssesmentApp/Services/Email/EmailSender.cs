﻿using Microsoft.AspNetCore.Identity.UI.Services;

namespace StaffAssesmentApp.Services.Email
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //TODO create email service
            await Task.CompletedTask;
        }
    }
}
