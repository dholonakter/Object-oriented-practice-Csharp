namespace Delegate
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path,PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            //    var filters=new PhotoFilter();
            //    filters.ApplyBrightness(photo);
            //    filters.ApplyContrast(photo);
            //    filters.Resize(photo);
            //    photo.Save();
        }
    }
}
