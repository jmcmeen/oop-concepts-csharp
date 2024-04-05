using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyMVP.Model;
using TinyMVP.View;

namespace TinyMVP.Presenter
{
    public class ImagePresenter
    {
        private IImageView _view;
        private ImageFile _imageFile;

        public ImagePresenter(IImageView view, ImageFile model)
        {
            _view = view;
            _view.ImagePresenter = this;
            _imageFile = model;
        }

        public void UpdateImageFile(string path)
        {
            _imageFile.Path = path;
            _view.ImagePath = path;
        }
    }
}
