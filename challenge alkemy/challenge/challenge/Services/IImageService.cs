namespace challenge.Services
{
    public interface IImageService
    {
        Task<string> StoreImage(IFormFile imageFile, ImageService.ImageType imageType);
    }
}