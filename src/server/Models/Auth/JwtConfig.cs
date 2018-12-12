namespace Models.Auth
{
    public class JwtConfig
    {
        public readonly string Issuer;
        public readonly string Audience;
        public readonly string SecretKey;
        
        public JwtConfig(string issuer, string audience, string secretKey)
        {
            Issuer = issuer;
            Audience = audience;
            SecretKey = secretKey;
        }
    }
}