﻿namespace FormWebSite.Entities.DTO.AppUserDTO
{
    public class UserSignInDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
