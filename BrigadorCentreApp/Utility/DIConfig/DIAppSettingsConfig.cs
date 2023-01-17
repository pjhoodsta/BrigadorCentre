using BrigadorCentreApp.Utility.AppSettingClasses;

namespace BrigadorCentreApp.Utility.DIConfig
{
    public static class DIAppSettingsConfig
    {
        public static IServiceCollection AddAppSettingsConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<HireSettings>(configuration.GetSection("HireSettings"));

            //implement these latler
            // services.Configure<StripeSettings>(configuration.GetSection("Stripe"));
            // services.Configure<SendGridSettings>(configuration.GetSection("SendGrid"));
            // services.Configure<TwilioSettings>(configuration.GetSection("Twilio"));
            return services;
        }
    }
}