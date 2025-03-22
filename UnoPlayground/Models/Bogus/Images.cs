using Bogus;

namespace UnoPlayground.Models.Bogus;

public class Image
{
    public Faker<ImageModel> Faker { get; init; }

    public Image()
    {
        Faker = new Faker<ImageModel>()
            .RuleFor(x => x.DataUri, f => f.Image.DataUri(640, 480))
            .RuleFor(x => x.PicsumUrl, f => f.Image.PicsumUrl())
            .RuleFor(x => x.PlaceholderUrl, f => f.Image.PlaceholderUrl(640, 480))
            .RuleFor(x => x.LoremFlickrUrl, f => f.Image.LoremFlickrUrl());
    }
}

public class ImageModel
{
    public string DataUri { get; set; }
    public string PicsumUrl { get; set; }
    public string PlaceholderUrl { get; set; }
    public string LoremFlickrUrl { get; set; }
}
