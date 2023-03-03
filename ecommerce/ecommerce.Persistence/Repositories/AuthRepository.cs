using AutoMapper;
using ecommerce.Application.Contracts;
using ecommerce.Application.DTOs.Auth;
using ecommerce.Application.Featuers;
using ecommerce.Domain.Entities;
using ecommerce.Persistence.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ecommerce.Persistence.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        protected readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthRepository(ApplicationDbContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<APIResponse> SendEmailForgotPassword(SendEmailForgotPassword.Request request)
        {

            var response = new APIResponse();
            try
            {
                Customer customer = _dbContext.Customers.AsTracking().Where(C => C.Email == request.Email).FirstOrDefault();

                if (customer is null)
                {
                    response.AddError(1);
                    response.Message = "This email does not exist.";
                    return response;
                }

                var forgotPassword = new ForgotPassword(request.Email);
                string code = forgotPassword.SendEmail();

                PasswordPrivacy passwordPrivacy = new PasswordPrivacy
                {
                    CustomerId = customer.CustomerId,
                    Code = code,
                    SentAt = DateTime.Now,
                };

                _dbContext.PasswordPrivacies.Add(passwordPrivacy);
                _dbContext.SaveChanges();

                response.Message = "Password reset code sent to email.";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = "Unexpected Error Occurred.";
                response.AddError(10);
                return response;
            }
        }
        public async Task<APIResponse<Login.Response>> Login(Login.Request request)
        {
            var response = new APIResponse<Login.Response>();

            try
            {
                var customer = _dbContext.Customers.Where(C => C.Email == request.EmailOrMobile || C.Mobile == request.EmailOrMobile).FirstOrDefault();

                if (customer is null)
                {
                    response.AddError(1);
                    response.Message = "Invalid Email Or Mobile";
                    return response;
                }

                PasswordEncryption passwordEncryption = new PasswordEncryption();
                
                if (!passwordEncryption.Verify(request.Password, customer.Password))
                {
                    response.AddError(1);
                    response.Message = "Invalid Password";
                    return response;
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.MobilePhone, customer.Mobile),
                    new Claim(ClaimTypes.NameIdentifier, customer.CustomerId.ToString()),
                    new Claim(ClaimTypes.Name, customer.FirstName),
                };
                var keyBuffer = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtOptions:SecretKey"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JwtOptions:Issuer"],
                    audience: _configuration["JwtOptions:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddDays(30),
                    signingCredentials: new SigningCredentials(keyBuffer, SecurityAlgorithms.HmacSha256));
                string tokenAsString = new JwtSecurityTokenHandler().WriteToken(token);

                response.Data = new Login.Response { Token = tokenAsString, ExpireDate = token.ValidTo, CustomerId = customer.CustomerId };

                return response;
            }
            catch (Exception ex)
            {
                response.Message = "Unexpected Error Occurred.";
                response.AddError(10);
                return response;
            }

        }
        public async Task<APIResponse> Register(Register.Request request)
        {
            var response = new APIResponse();

            try
            {
                var customer =  _dbContext.Customers.Where(C => C.Mobile == request.Mobile).FirstOrDefault();

                if (customer != null)
                {
                    response.AddError(3);
                    response.Message = "Mobile Already Exists.";
                    return response;
                }
                else if (customer.Email.Equals(request.Email))
                {
                    response.AddError(3);
                    response.Message = "Email Already Exists.";
                    return response;
                }

                var newCustomer = _mapper.Map<Customer>(request);

                PasswordEncryption passwordEncryption = new PasswordEncryption();

                newCustomer.Password = passwordEncryption.Encrypt(request.Password);
                
                _dbContext.Customers.Add(newCustomer);
                _dbContext.SaveChanges();

                response.Message = "Registered Successfully.";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = "Unexpected Error Occurred.";
                response.AddError(10);
                return response;
            }

        }
        public async Task<APIResponse> PasswordConfirmationCode(PasswordConfirmationCode.Request request)
        {
            var response = new APIResponse();

            try
            {
                Customer customer = _dbContext.Customers.AsTracking().Where(C => C.Email == request.Email).FirstOrDefault();

                if (customer is null)
                {
                    response.AddError(1);
                    response.Message = "Email does not exist.";
                    return response;
                }

                var PasswordConfirmation = _dbContext.PasswordPrivacies.AsTracking().Where(p => p.CustomerId == customer.CustomerId).FirstOrDefault();
                if(PasswordConfirmation is null)
                {
                    response.AddError(1);
                    response.Message = "Do not have a Confirmation code.";
                    return response;
                }

                if (PasswordConfirmation.IsConfirmed)
                {
                    response.AddError(1);
                    response.Message = "Confirmation code is expierd.";
                    return response;
                }

                if (!PasswordConfirmation.Code.Equals(request.Code))
                {
                    response.AddError(1);
                    response.Message = "Confirmation code is not valid.";
                    return response;
                }

                PasswordConfirmation.ConfirmedAt = DateTime.Now;
                PasswordConfirmation.IsConfirmed = true;
                _dbContext.SaveChanges();

                response.Message = "Confirmation code is valid.";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = "Unexpected Error Occurred.";
                response.AddError(10);
                return response;
            }
        }
    }
}
