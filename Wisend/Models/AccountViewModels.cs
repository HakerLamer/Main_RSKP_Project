﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using Wisend.Properties;

namespace Wisend.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Phone]
        [Display(Name ="Мобильный телефон")]
        public string PhoneNumber { get; set;}
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
    }
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Код")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Запомнить браузер?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Phone]
        [Display(Name ="Мобильный телефон")]
        public string PhoneNumber { get; set;}
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {

        static public bool CreateAccount(string Login, string Phone_number, string Password)
        {
            try
            {
                string ConnectionString = BDTypes.StringConnection;
                string sqlExpression = BDTypes.CreateAccount;
                using (SqlConnection connect = new SqlConnection(ConnectionString))
                {
                    connect.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connect);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    string [] sqlparam = new string []
                    {
                  Login,
                  Phone_number,
                  Password,
                    };
                    string[] ParamInSql = new string[]
                        {
                        "@Login",
                        "@Phone_number",
                        "@Password",
                        };
                    for (int i = 0; i < sqlparam.Length; i++)
                    {
                        SqlParameter NameParamm = new SqlParameter
                        {
                            ParameterName = ParamInSql[i],
                            Value = sqlparam[i]
                        };
                        command.Parameters.Add(NameParamm);
                    }
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "models.log"), $"[{DateTime.Now}] {ex.Message}\n");
                return false;
            }
        }
        [Required]
        [Display(Name ="Логин")]
        public string Login { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Мобильный телефон")]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [Phone]
        [Display(Name ="Мобильный телефон")]
        public string PhoneNumber { get; set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [Phone]
        [Display(Name ="Мобильный телефон")]
        public string PhoneNimber { get; set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Почта")]
        public string Email { get; set; }
    }
}
