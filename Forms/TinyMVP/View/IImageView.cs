using TinyMVP.Presenter;

namespace TinyMVP.View
{
    public interface IImageView
    {
        public string ImagePath { get; set; }

        public ImagePresenter ImagePresenter { set; }
    }
}
