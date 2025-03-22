using Bogus;
using System.Net;

namespace UnoPlayground.Models.Bogus;

public class Internet
{
    public Faker<InternetModel> Faker { get; init; }

    public Internet()
    {
        Faker = new Faker<InternetModel>()
            .RuleFor(x => x.Avatar, f => f.Internet.Avatar())
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.ExampleEmail, f => f.Internet.ExampleEmail())
            .RuleFor(x => x.UserName, f => f.Internet.UserName())
            .RuleFor(x => x.UserNameUnicode, f => f.Internet.UserNameUnicode())
            .RuleFor(x => x.DomainName, f => f.Internet.DomainName())
            .RuleFor(x => x.DomainWord, f => f.Internet.DomainWord())
            .RuleFor(x => x.DomainSuffix, f => f.Internet.DomainSuffix())
            .RuleFor(x => x.Ip, f => f.Internet.Ip())
            .RuleFor(x => x.Port, f => f.Internet.Port())
            .RuleFor(x => x.IpAddress, f => f.Internet.IpAddress())
            .RuleFor(x => x.IpEndPoint, f => f.Internet.IpEndPoint())
            .RuleFor(x => x.Ipv6, f => f.Internet.Ipv6())
            .RuleFor(x => x.Ipv6Address, f => f.Internet.Ipv6Address())
            .RuleFor(x => x.Ipv6EndPoint, f => f.Internet.Ipv6EndPoint())
            .RuleFor(x => x.UserAgent, f => f.Internet.UserAgent())
            .RuleFor(x => x.Mac, f => f.Internet.Mac())
            .RuleFor(x => x.Password, f => f.Internet.Password())
            .RuleFor(x => x.Color, f => f.Internet.Color())
            .RuleFor(x => x.Protocol, f => f.Internet.Protocol())
            .RuleFor(x => x.Url, f => f.Internet.Url())
            .RuleFor(x => x.UrlWithPath, f => f.Internet.UrlWithPath())
            .RuleFor(x => x.UrlRootedPath, f => f.Internet.UrlRootedPath());
    }
}

public class InternetModel
{
    public string Avatar { get; set; }
    public string Email { get; set; }
    public string ExampleEmail { get; set; }
    public string UserName { get; set; }
    public string UserNameUnicode { get; set; }
    public string DomainName { get; set; }
    public string DomainWord { get; set; }
    public string DomainSuffix { get; set; }
    public string Ip { get; set; }
    public int Port { get; set; }
    public IPAddress IpAddress { get; set; }
    public IPEndPoint IpEndPoint { get; set; }
    public string Ipv6 { get; set; }
    public IPAddress Ipv6Address { get; set; }
    public IPEndPoint Ipv6EndPoint { get; set; }
    public string UserAgent { get; set; }
    public string Mac { get; set; }
    public string Password { get; set; }
    public string Color { get; set; }
    public string Protocol { get; set; }
    public string Url { get; set; }
    public string UrlWithPath { get; set; }
    public string UrlRootedPath { get; set; }
}
